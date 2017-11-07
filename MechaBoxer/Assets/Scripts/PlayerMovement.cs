using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // created a new rigidbody for the script to access (drag and drop)
    public Rigidbody rb;

    // force moving forward
    public float forwardForce = 2000f;

    // force moving to the side
    public float sidewaysForce = 500f;

    // Unity likes FixedUpdate more than Update with Physics based interactions
    void FixedUpdate ()
    {
        //adds a force to the rigidbody multiplied by a lesser value as time goes on
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //Player movement (just keyed for now)
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
