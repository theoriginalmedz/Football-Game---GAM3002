using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blackEyes8Lives : MonoBehaviour
{
    public GameObject ball1, ball2, ball3, ball4, ball5, balls6, balls7, balls8;
    public static int health;
    public GameObject BALL;

    void Start()
    {
        health = 8;
        ball1.gameObject.SetActive(true);
        ball2.gameObject.SetActive(true);
        ball3.gameObject.SetActive(true);
        ball4.gameObject.SetActive(true);
        ball5.gameObject.SetActive(true);
        balls6.gameObject.SetActive(true);
        balls7.gameObject.SetActive(true);
        balls8.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 8)
            health = 8;

        switch (health)
        {
            case 8:
                ball1.gameObject.SetActive(true);
                ball2.gameObject.SetActive(true);
                ball3.gameObject.SetActive(true);
                ball4.gameObject.SetActive(true);
                ball5.gameObject.SetActive(true);
                balls6.gameObject.SetActive(true);
                balls7.gameObject.SetActive(true);
                balls8.gameObject.SetActive(true);
                break;
            case 7:
                ball1.gameObject.SetActive(true);
                ball2.gameObject.SetActive(true);
                ball3.gameObject.SetActive(true);
                ball4.gameObject.SetActive(true);
                ball5.gameObject.SetActive(true);
                balls6.gameObject.SetActive(true);
                balls7.gameObject.SetActive(true);
                balls8.gameObject.SetActive(false);
                break;
            case 6:
                ball1.gameObject.SetActive(true);
                ball2.gameObject.SetActive(true);
                ball3.gameObject.SetActive(true);
                ball4.gameObject.SetActive(true);
                ball5.gameObject.SetActive(true);
                balls6.gameObject.SetActive(true);
                balls7.gameObject.SetActive(false);
                balls8.gameObject.SetActive(false);
                break;
            case 5:
                ball1.gameObject.SetActive(true);
                ball2.gameObject.SetActive(true);
                ball3.gameObject.SetActive(true);
                ball4.gameObject.SetActive(true);
                ball5.gameObject.SetActive(true);
                balls6.gameObject.SetActive(false);
                balls7.gameObject.SetActive(false);
                balls8.gameObject.SetActive(false);
                break;
            case 4:
                ball1.gameObject.SetActive(true);
                ball2.gameObject.SetActive(true);
                ball3.gameObject.SetActive(true);
                ball4.gameObject.SetActive(true);
                ball5.gameObject.SetActive(false);
                balls6.gameObject.SetActive(false);
                balls7.gameObject.SetActive(false);
                balls8.gameObject.SetActive(false);
                break;
            case 3:
                ball1.gameObject.SetActive(true);
                ball2.gameObject.SetActive(true);
                ball3.gameObject.SetActive(true);
                ball4.gameObject.SetActive(false);
                ball5.gameObject.SetActive(false);
                balls6.gameObject.SetActive(false);
                balls7.gameObject.SetActive(false);
                balls8.gameObject.SetActive(false);
                break;

            case 2:
                ball1.gameObject.SetActive(true);
                ball2.gameObject.SetActive(true);
                ball3.gameObject.SetActive(false);
                ball4.gameObject.SetActive(false);
                ball5.gameObject.SetActive(false);
                balls6.gameObject.SetActive(false);
                balls7.gameObject.SetActive(false);
                balls8.gameObject.SetActive(false);
                break;
            case 1:
                ball1.gameObject.SetActive(true);
                ball2.gameObject.SetActive(false);
                ball3.gameObject.SetActive(false);
                ball4.gameObject.SetActive(false);
                ball5.gameObject.SetActive(false);
                balls6.gameObject.SetActive(false);
                balls7.gameObject.SetActive(false);
                balls8.gameObject.SetActive(false);
                break;
            case 0:
                ball1.gameObject.SetActive(false);
                ball2.gameObject.SetActive(false);
                ball3.gameObject.SetActive(false);
                ball4.gameObject.SetActive(false);
                ball5.gameObject.SetActive(false);
                balls6.gameObject.SetActive(false);
                balls7.gameObject.SetActive(false);
                balls8.gameObject.SetActive(false);
                StartCoroutine(test());
                break;

        }
    }

    public IEnumerator test()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(10);
    }

}


