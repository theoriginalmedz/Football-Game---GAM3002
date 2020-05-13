using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlimitedTimesJustgameplay : MonoBehaviour
{
    [SerializeField]
    GameObject musicMana;

    public void Awake()
    {
       musicMana.SetActive(true);
        
    }

    public void playGameAgain()
    {
        SceneManager.LoadScene(32); //make this scene the scene that the unlimited game is on
    }

    public void backToMenu()
    {
        
        SceneManager.LoadScene(0); //make this scene the next scene you go to when you want to go home
        musicMana.SetActive(false);


    }
}
