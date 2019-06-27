using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 20f;
    public float sidewayForce = 500f;

    void Start()
    {
        //rb.useGravity = false;
        rb.AddForce(0, 0, forwardForce);
        // rb.AddForce(0, 200, 2000 * Time.deltaTime);  <= keep going non stop.
    }

    public void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(forwardForce * Time.deltaTime, 0, 0);
            
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {

            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }
    }

    public void FixUpdate()
    {
        
        
        
    }
}
