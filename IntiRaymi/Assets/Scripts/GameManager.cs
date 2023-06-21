using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int currentScore = 0;
    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
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
        Debug.Log("end game!!!");
    }
}
