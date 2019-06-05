using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {


    public void StartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StartEndless() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

}
