using UnityEngine;

public class MoveCube : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // The reason why FixedUpdate is here is because Unity likes when we use FixedUpdate when we use physics related things in C#
    void FixedUpdate ()
    {
        
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce* Time.deltaTime,0,0);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0);
        }
    }
}