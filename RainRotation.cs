using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainRotation : MonoBehaviour
{
    public float rotationSpeed; // Public variable to control the rotation speed.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This function is called once per frame, and it's used to continuously rotate the GameObject.
        transform.Rotate(0, -rotationSpeed, 0);
    }
}
