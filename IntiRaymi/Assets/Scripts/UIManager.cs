using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "0/5 Items Found";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateFoundItemScore(int newScore)
    {
        scoreText.text = newScore.ToString() + "/5 Items Found";
    }
}
