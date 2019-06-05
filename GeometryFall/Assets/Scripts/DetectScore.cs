using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectScore : MonoBehaviour {

    public Material objectHitGroundMat;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Obstacle") {
            FindObjectOfType<Score>().IncreaseScore();
            if (SceneManager.GetActiveScene().buildIndex == 1  || SceneManager.GetActiveScene().buildIndex == 2 ||
                SceneManager.GetActiveScene().buildIndex == 6) {
                collision.gameObject.GetComponent<Renderer>().material = objectHitGroundMat;
                collision.gameObject.tag = "Safe";
            }
        }
    }
}
