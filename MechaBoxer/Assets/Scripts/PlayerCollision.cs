using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    // Makes a playermovement script object that you drag in
    public PlayerMovement movement;

    // Once the player object collides with another object do this
    void OnCollisionEnter(Collision collisionInfo)
    {
        // If the player collides with a GameObject possessing an OBSTACLE tag, do this
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("hit obstacle"); // log file stating the obstacle was hit
            movement.enabled = false; // turns off the PlayerMovement script, removing the force being added to it, and stopping the player

            // Finds the GameManager script and calls its EndGame() function
            FindObjectOfType<GameManager>().EndGame();
            
            
        }
    }
}
