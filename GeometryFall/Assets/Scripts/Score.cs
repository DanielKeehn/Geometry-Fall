using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    int currentScore;
    public Text scoreText;
    public int goalScore;

    // Use this for initialization
    void Start() {
        Debug.Log("Screen Width : " + Screen.width);
        Debug.Log("Screen Width : " + Screen.height);
        currentScore = 0;
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            goalScore = 10;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        { 
            goalScore = 20;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            goalScore = 10;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            goalScore = 20;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            goalScore = 50;
        }

    }
	
	// Update is called once per frame
	public void IncreaseScore() {
        currentScore++;
        scoreText.text = currentScore.ToString();
        if (currentScore >= goalScore && SceneManager.GetActiveScene().buildIndex != 6) {
            FindObjectOfType<GameManager>().CompleteLevel();
        }
    }
}
