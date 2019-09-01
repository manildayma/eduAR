using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class label : MonoBehaviour
{
    
    public GameObject labelObject;
    

    public void exitButton(){  Application.Quit();  }
    public void backButton(){ SceneManager.LoadScene("main"); }
    public void engineButton(){ SceneManager.LoadScene("engine"); }
    public void motorButton(){ SceneManager.LoadScene("motor"); }
    public void skullButton(){ SceneManager.LoadScene("skull"); }
    public void gearButton(){ SceneManager.LoadScene("gear"); }
    public void brainButton(){ SceneManager.LoadScene("brain"); }
    public void heartButton(){ SceneManager.LoadScene("heart"); }


    
    
    public void lableToggle()
    {
        if ( !labelObject.activeInHierarchy ) { labelObject.SetActive(true); }
        else { labelObject.SetActive(false); }

    }

}
