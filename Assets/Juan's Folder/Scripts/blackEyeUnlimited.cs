using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blackEyeUnlimited : MonoBehaviour
{

    public void RestarGame()
    {
        SceneManager.LoadScene(12); //make this scene the scene that the unlimited game is on
    }

    public void goHome()
    {
        SceneManager.LoadScene(13); //make this scene the next scene you go to when you want to go home

    }
}
