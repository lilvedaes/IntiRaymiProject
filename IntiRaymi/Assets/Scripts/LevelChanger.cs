using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator FadeOutAnimation()
    {
        yield return new WaitForSeconds(10);
        animator.SetTrigger("FadeOut");
    }

    public void InstantFade()
    {
        animator.SetTrigger("FadeOut");
    }
    public void OnFadeComplete()
    {
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
}
