using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class FloorManager : MonoBehaviour 
{
    public static FloorManager instance;   
    public List<Floors> floors; //list of floors 
    public UnityEvent onChanged; 
    void Awake ( ){ 
        //Singleton Instantiation Method
        if (instance == null) { 
            instance=this;
        } 
        else{
            Debug. LogError ("Duplicated Floors");
        }  
}
    public void addFloor (Floors floor) {
        floors.Add (floor); //Adds floor to list floors 
        onChanged.Invoke();  
        }
    public void removeFloor (Floors floor) { 
        floors.Remove(floor);// removes floor from list
        Destroy(floor. gameObject); //deletes floor from scene 
        onChanged.Invoke () ;
    }
    public void removeRandom (){ 
        if (floors.Count <= 0) { 
            print("List length must be greater than 0."); 
        } 
        //generates a random number within the range of the list floors. 
        //generated number will be the index of the element in the list that will be deleted 
        int randomIndex = Random.Range(0, floors. Count) ; 
        
        //creates an element of type Floor and assigns it to the random index generated before 
        //this random element of the list is the one we are going to delete when a bullet hits a wall 
        Floors floorToRemove = floors [randomIndex]; 
        
        //invokes removeFloor() function and passes as an argument the element to delete, pre determined 
        //in previous lines of code 
        removeFloor (floorToRemove);  
    }
    public void removeAll(){
        //iterates through the list and delete every element(floors) in the list 
        //this function will execute when called in the ContactDestrover script 
        for(int i = 0;i <= floors.Count; i++) {
            removeFloor(floors [i]);
        }
    }
}