using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class BattonPlay : MonoBehaviour
{
    public void PlayGame()
    {
      SceneManager.LoadScene(1);
        
    }
    public void ExitGame()
    {
        Application.Quit();
       
    }
    public void Levl2()
    {
        SceneManager.LoadScene(2);
    }
}
