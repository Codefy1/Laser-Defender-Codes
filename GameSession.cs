using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{

    int score = 0;

    private void Awake() //runs before start method.
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        int numberGameSessions = FindObjectsOfType<GameSession>().Length; 
        if (numberGameSessions > 1)
        {
            Destroy(gameObject); //destroys the game object.
        }
        else
        {
            DontDestroyOnLoad(gameObject); //don't destroy the game object when the next scene loads
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void AddToScore(int scoreValue)
    {
        score += scoreValue; //updation of score.
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

}