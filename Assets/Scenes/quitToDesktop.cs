using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quitToDesktop : MonoBehaviour
{
    public void quitGame()
    {
        Application.Quit();
        print("Game quit");
        Debug.Log("Game has quit");
    }

    public void backToMain()
    {
        SceneManager.LoadScene(28);
    }
}
