using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicManager : MonoBehaviour
{ 


    private GameObject[] musicGame;

    void Start()
    {
        musicGame = GameObject.FindGameObjectsWithTag("GameMusic");
        Destroy(musicGame[1]);
    }

    // Update is called once per frame
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}