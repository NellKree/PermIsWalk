using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public int Level;
    public int Numberscene;
    public void StartLevelButton()
    {
        DataHolder.levelStart = Level;
        DataHolder.SceneNumber = Numberscene;
        SceneManager.LoadScene(3);
    }
    public void StartInstaLevelButton()
    {
        DataHolder.levelStart = Level;
        DataHolder.SceneNumber = Numberscene;
        SceneManager.LoadScene(6);
    }
}
