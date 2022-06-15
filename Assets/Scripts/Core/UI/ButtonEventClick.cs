using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

/*
  Todos los eventos de los botones presentes en las botas UI.
*/

public class ButtonEventClick : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadScene("ARSphere");
    }

    public void GoBack()
    {
        SceneManager.LoadScene("ARDraw");
    }

    public void CloseMenu()
    {
        SceneManager.LoadScene("ARDraw");
    }

    public void GoBack2()
    {
        SceneManager.LoadScene("ARSphere");
    }

    public void GoBack3()
    {
        SceneManager.LoadScene("ARAllSphere");
    }

    public void ChangeScene2()
    {
        SceneManager.LoadScene("ARAllSphere");
    }

    public void ChangeScene3()
    {
        SceneManager.LoadScene("ARAddObj");
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void CloseApp()
    {
        Application.Quit();
    }
}
