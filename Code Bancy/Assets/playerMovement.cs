using System.Collections;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public Rigidbody rb;

    private float speed = 10f;
    private float jumpf = 8f;
    private Vector3 movedlr = Vector3.zero;
    private float gravity = 30f;

    /*public float forward = 2000;
    public float left = 2000;
    public float right = 2000;
    public float back = 2000;
    public float rotate = 500;
    */
    void Start ()
    {

    }

    // Use this for initialization
    void update()
    {
        //Debug.Log("hello, world");
        CharacterController controller = gameObject.GetComponent<CharacterController>();

        if (controller.isGrounded)
        {
            movedlr = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            movedlr = transform.TransformDirection(movedlr);

            movedlr *= speed;

            if (Input.GetButtonDown("Jump"))
            {
                movedlr.y = jumpf;

            }

            movedlr.y *= gravity * Time.deltaTime;

            controller.Move(movedlr * Time.deltaTime);
        }

          
        }
            

        


    
	// Update is called once per frame
	/* void FixedUpdate () {
       if (Input.GetKey("e")) { 
        rb.AddTorque(0, rotate, 0, ForceMode.VelocityChange);
        }
     
        if (Input.GetKey("q"))
        {
            rb.AddTorque(0, -rotate * Time.deltaTime, 0, ForceMode.VelocityChange);
        }


        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -back * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w")) { 
        rb.AddForce(0, 0, forward * Time.deltaTime, ForceMode.VelocityChange);
       }
        if (Input.GetKey("d"))
        {
            rb.AddForce(left * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                   }
        if (Input.GetKey("a"))
        {
            rb.AddForce( -right * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


	}*/
}
