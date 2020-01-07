using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator ControllAnimator;

    public void PlayButtonClickHandler()
    {
        SceneManager.LoadScene("Game");
    }

    public void ShowCreatorslButtonClickHandler()
    {
        ControllAnimator.SetBool("IsOpen", !ControllAnimator.GetBool("IsOpen"));
    }

    public void ExitButtonClickHandlert()
    {
        Application.Quit();
    }
}
