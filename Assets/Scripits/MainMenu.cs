using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("SampleScene");

    }
    public void QuitGame()
    {
#if UNITY_EDITOR
UnityEditor.EditorApplication.isPlaying=false;
#else
        Application.Quit();
#endif 
    }
    public void ExitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
