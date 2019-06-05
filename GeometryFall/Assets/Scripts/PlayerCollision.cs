using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public boxCollider movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Obstacle") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().gameOver();
        }
    }
}