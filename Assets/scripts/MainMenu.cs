using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("level1");
    }
}