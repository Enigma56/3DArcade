using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

/*
 * MAYBE I DO NOT NEED A SINGLETON; PLEASE THINK ABOUT THIS A BIT MORE!
 */
public class UIMethods : MonoBehaviour
{
    //public static UIMethods Instance { get; private set; }

    private Canvas uiCanvas;

    private void Awake()
    {
        uiCanvas = GetComponentInChildren<Canvas>();
        uiCanvas.enabled = false;
        
        Debug.Log("UI awake!");
    }

    public void Exit()
    {
        #if UNITY_EDITOR
        
            if(SceneManager.GetActiveScene().name == "Lobby")
                UnityEditor.EditorApplication.isPlaying = false;
            else
            {
                Debug.Log("loaded lobby!");
                SceneManager.LoadScene("Lobby");
            }
        #endif
        
        Application.Quit();
    }

    public void DisplayUI()
    {
        if (uiCanvas.enabled)
        {
            uiCanvas.enabled = false;
            Time.timeScale = 1;
        }
        else
        {
            uiCanvas.enabled = true;
            Time.timeScale = 0;
        }
    }
}
