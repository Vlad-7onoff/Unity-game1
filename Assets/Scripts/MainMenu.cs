using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Animator ControllAnimator;

    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnShowCreatorslButtonClick()
    {
        ControllAnimator.SetBool("IsOpen", !ControllAnimator.GetBool("IsOpen"));
    }

    public void OnExitButtonClick()
    {
        Application.Quit();
    }
}
