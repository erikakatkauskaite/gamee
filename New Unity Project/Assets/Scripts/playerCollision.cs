using UnityEngine;

public class playerCollision : MonoBehaviour {

    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //Debug.Log("We hit an obstacle");
           // movement.enabled = false;
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GamManager>().GameOver();
            
        }
    }
}
