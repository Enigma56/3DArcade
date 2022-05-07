using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonAsteroids : MonoBehaviour
{
    public SingletonAsteroids Instance { get; private set; }

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

    // Update is called once per frame
    void Update()
    {
        
    }
}
