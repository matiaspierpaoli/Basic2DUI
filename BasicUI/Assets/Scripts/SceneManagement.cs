using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManagement : MonoBehaviour
{
    public void GameScene()
    {
        SceneManager.LoadScene("GameplayScene");
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
        SceneManager.LoadScene("MainMenuScene");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
