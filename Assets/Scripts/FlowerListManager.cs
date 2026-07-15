using UnityEngine;
using UnityEngine.SceneManagement;

public class FlowerListManager : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Test()
    {
        Debug.Log("TEST");
    }
}