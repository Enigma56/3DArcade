using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * MAYBE I DO NOT NEED A SINGLETON; PLEASE THINK ABOUT THIS A BIT MORE!
 */
public class UISingleton : MonoBehaviour
{
    public static UISingleton Instance { get; private set; }

    private Canvas uiCanvas;

    private void Awake()
    {
        if(Instance != null && Instance != this)
            Destroy(this);
        else
        {
            Instance = this;
        }

        uiCanvas = GetComponentInChildren<Canvas>();
        uiCanvas.enabled = false;
        
        Debug.Log("UI awake!");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            Instance.DisplayUI();
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
        uiCanvas.enabled = !uiCanvas.enabled;
    }
}
