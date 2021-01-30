
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; // Disable the player's movement
            FindObjectOfType<GameManager>().EndGame();
            //Debug.Log("We hit an obstacle");
        }
        
    }


}
