using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class BattonPlay : MonoBehaviour
{
    public GameObject chooseLevle;
    public GameObject Levle2batton;

    public void Start()
    {
        levlenum();
        
    }
   
    public void OpenChoose()
    {
        chooseLevle.SetActive(true);
    }


    
    public void ExitGame()
    {
        Application.Quit();
       
    }
    public void Levl2()
    {
        SceneManager.LoadScene(2); 
    }
    public void ClosePanel()
    {
        chooseLevle.SetActive(false);
    }
    public void go1levle()
    {
        SceneManager.LoadScene(1);
    }
    public void levlenum()
    {
        Levle2batton.GetComponent<Button>().interactable = false;
        if (PlayerPrefs.GetInt("Whatlevle") == 2)
        {
            Levle2batton.GetComponent<Button>().interactable = true;
        }
    }
}
