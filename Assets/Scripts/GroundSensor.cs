using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool isGrounded;

<<<<<<< HEAD
    void OnTriggerEnter2D(Collider2D other) 
    {
      isGrounded=true;  
    }
     void OnTriggerExit2D(Collider2D other) 
=======
    void OnTriggerEnter2D(Collider2D other)
    {
        isGrounded = true; 
    }

    void OnTriggerExit2D(Collider2D other)
>>>>>>> 96dad96b9c1c0adfcf8c3407f106aeaa6520d26d
    {
        isGrounded = false;
    }
}
<<<<<<< HEAD
    
=======
>>>>>>> 96dad96b9c1c0adfcf8c3407f106aeaa6520d26d
