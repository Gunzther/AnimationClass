using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    Animator optionsBackground;

    [SerializeField]
    Animator options;

    public void GoToGameplay()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void AnimateOptions()
    {
        optionsBackground.SetTrigger("animateBG");
        options.SetTrigger("animateOptionsBoard");
    }

}
