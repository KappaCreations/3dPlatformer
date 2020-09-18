﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;
    public int score = 0;
   

    
    // Start is called before the first frame update
    void Start()
    {

        
        if (instance == null)
        {
            instance = this;
        }
    
        if(instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
       


    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
   
    }

    public void AddScore(int amount)
    {
        score += amount;
    }

    



}
