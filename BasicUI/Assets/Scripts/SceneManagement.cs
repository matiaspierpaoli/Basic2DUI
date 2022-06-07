using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManagement : MonoBehaviour
{
    public void GameScene()
    {
        SceneManager.LoadScene("Gameplay");
    }
   
    public void OptionsScene()
    {
        SceneManager.LoadScene("OptionsScene");
    }

    public void CreditsScene()
    {
        SceneManager.LoadScene("CreditsScene");
    }
   
    public void ReturnToMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
