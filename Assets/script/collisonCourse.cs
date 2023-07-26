using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisonCourse : MonoBehaviour
{
    public playerMovement playerMovement;
    public GameController gameController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collectables")
        {
            Destroy(other.gameObject); 
        }           
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "obstacle")
        {
            gameController.gameOver();
            playerMovement.enabled = false;
            
        }
    }
}
