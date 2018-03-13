using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideWay = 500f;

	// Use this for initialization
	//void Start ()
 //   {
 //       //Debug.Log("Hello");
 //       //rb.useGravity = false;
 //       rb.AddForce(0, 200, 500);
	//}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardForce *Time.deltaTime);
        
        if (Input.GetKey("d"))
        {
            rb.AddForce( sideWay* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWay * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GamManager>().GameOver();
        }
    }
}
