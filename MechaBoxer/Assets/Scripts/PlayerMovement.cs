using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // created a new rigidbody for the script to access (drag and drop)
    public Rigidbody rb;

	
	
	// Unity likes FixedUpdate more than Update with Physics based interactions
	void FixedUpdate ()
    {
        //adds a force to the rigidbody multiplied by a lesser value as time goes on
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
