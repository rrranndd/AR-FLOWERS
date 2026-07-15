using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void OpenAR()
    {
        SceneManager.LoadScene("ARScene");
    }

    public void OpenGuide()
    {
        SceneManager.LoadScene("GuideScene");
    }

    public void OpenFlowerList()
    {
        SceneManager.LoadScene("FlowerListScene");
    }

    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("Keluar Aplikasi");
    }
}