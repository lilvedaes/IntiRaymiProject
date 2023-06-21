using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public UIManager uiManager;
    public Image fadeInBlack;
    int currentScore;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentScore == 5)
        {
            EndGame();
        }
    }

    public void NextScene()
    {
        // Show fade in animation


        // Load next scene
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

    public int GetScore()
    { return currentScore; }

    public void UpdateScore()
    {
        currentScore = currentScore + 1;
        uiManager.UpdateFoundItemScore(currentScore);
    }

    public void EndGame()
    {
        NextScene();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
