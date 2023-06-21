using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public UIManager uiManager;
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
}
