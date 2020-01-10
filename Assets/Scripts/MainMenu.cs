using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator ControllAnimator;

    public void PlayButtonClick()
    {
        SceneManager.LoadScene("Game");
    }

    public void ShowCreatorslButtonClick()
    {
        ControllAnimator.SetBool("IsOpen", !ControllAnimator.GetBool("IsOpen"));
    }

    public void ExitButtonClick()
    {
        Application.Quit();
    }
}
