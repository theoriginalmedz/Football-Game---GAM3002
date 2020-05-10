using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blackEyeLimitedGameManagement : MonoBehaviour
{
    private GameObject[] Target;

    public GameObject Panel;

    private void Start()
    {
        Panel.SetActive(false);
    }

    void Update()
    {
        Target = GameObject.FindGameObjectsWithTag("Enemy");
        if (Target == null) { return; }

        if (Target.Length == 0)
        {
            Panel.SetActive(true);
        }

        if (Score.scorevalue >= 40) //change the score requirement to win
        {
            SceneManager.LoadScene(9); //change the scene

        }
    }
}
