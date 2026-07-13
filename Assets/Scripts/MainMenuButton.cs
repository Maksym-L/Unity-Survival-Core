using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void LoadScene() 
    {
      SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1.0f;
    }
}
