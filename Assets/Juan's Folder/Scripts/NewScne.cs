using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScne : MonoBehaviour
{
   


    public void RestarGame()
    {
        SceneManager.LoadScene(3); //make this scene the scene that the unlimited game is on
    }

    public void goHome()
    {
        SceneManager.LoadScene(4); //make this scene the next scene you go to when you want to go home
        SceneManager.UnloadScene(3); //unloads this scene
    }
}
