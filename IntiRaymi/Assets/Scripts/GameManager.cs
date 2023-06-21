using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public LevelChanger changer;
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
        if (currentScore == 1)
        {
            EndGame();
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
        changer.FadeOutAnimation();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
