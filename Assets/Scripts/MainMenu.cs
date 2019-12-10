using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator ControllAnimator;

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void ChangeContorl()
    {
        ControllAnimator.SetBool("IsOpen", !ControllAnimator.GetBool("IsOpen"));
    }

    public void Exit()
    {
        Application.Quit();
    }
}
