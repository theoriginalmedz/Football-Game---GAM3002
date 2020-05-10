using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class livesOnly3forSub : MonoBehaviour
{

    public GameObject ball1, ball2, ball3;
    public static int health;
    public GameObject BALL;
    void Start()
    {
        health = 3;
        ball1.gameObject.SetActive(true);
        ball2.gameObject.SetActive(true);
        ball3.gameObject.SetActive(true);
        



    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
            health = 3;

        switch (health)
        {
            
            case 3:
                ball1.gameObject.SetActive(true);
                ball2.gameObject.SetActive(true);
                ball3.gameObject.SetActive(true);
                
                break;
            case 2:
                ball1.gameObject.SetActive(true);
                ball2.gameObject.SetActive(true);
                ball3.gameObject.SetActive(false);
               

                break;
            case 1:
                ball1.gameObject.SetActive(true);
                ball2.gameObject.SetActive(false);
                ball3.gameObject.SetActive(false);
                
                break;
            case 0:
                ball1.gameObject.SetActive(false);
                ball2.gameObject.SetActive(false);
                ball3.gameObject.SetActive(false);
                
                StartCoroutine(test());
                break;
        }
    }

    public IEnumerator test()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(18);
    }

}
