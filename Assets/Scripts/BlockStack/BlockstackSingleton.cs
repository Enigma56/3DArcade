using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BlockstackSingleton : MonoBehaviour
{
    public static BlockstackSingleton Instance { get; private set; }
    public int StackHeight { get; private set; }
    public TextMeshProUGUI HeightText;

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
    
    public void IncreaseStackHeight()
    {
        StackHeight++;
    }

    public void IncreaseScore()
    {
        Instance.HeightText.text = Instance.StackHeight.ToString();
    }
}
