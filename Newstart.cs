using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Text;
using System;



public class Newstart : MonoBehaviour
{
    public void Go()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    public void GoToArea()
    {
        SceneManager.LoadScene(3);
    }
    public void GoToAreaList()
    {
        SceneManager.LoadScene(2);
    }
    public void GoMapOrList()
    {
        switch (DataHolder.SceneNumber)
        {

            case 0:
                SceneManager.LoadScene(1);
                break;
            case 1:
                SceneManager.LoadScene(2);
                break;           
        }
    }
    public void GoToInstaList()
    {
        SceneManager.LoadScene(4);
    }
    public void GoToInstaMap()
    {
        SceneManager.LoadScene(5);
    }
    public void GoToInstaPoint()
    {
        SceneManager.LoadScene(6);
    }
    public void GoInstaMapOrList()
    {
        switch (DataHolder.SceneNumber)
        {

            case 0:
                SceneManager.LoadScene(5);
                break;
            case 1:
                SceneManager.LoadScene(4);
                break;
        }
    }

    //public void browse()
    // {
    //     Application.OpenURL(websiteadress.nWeb);
    // }
    // public void Copy()
    // {
    //     UniClipboard.SetText(cop.nco);

    // }
    // public void GoSEt()
    // {
    //     SceneManager.LoadScene(2);
    // }


}


