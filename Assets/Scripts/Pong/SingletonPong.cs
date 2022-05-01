using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SingletonPong : MonoBehaviour
{
    public static SingletonPong Instance;
    
    public TextMeshProUGUI playerOneScoreText;
    public int playerOneScore;
    
    public TextMeshProUGUI playerTwoScoreText;
    public int playerTwoScore;

    private void Awake()
    {
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        }
    }
    
    
}
