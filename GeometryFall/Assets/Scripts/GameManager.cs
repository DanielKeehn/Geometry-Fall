using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool GameHasEnded = false;
    public float restartDelay = 0.5f;
    public GameObject completeLevelUI;
  
    public void gameOver() {
        if (GameHasEnded == false && SceneManager.GetActiveScene().buildIndex != 6)
        {
            GameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
        else {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }
}