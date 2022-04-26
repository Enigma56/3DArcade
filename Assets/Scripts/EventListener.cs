using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    public GameObject PauseUI;
    protected virtual void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseUI.GetComponent<UIMethods>().DisplayUI(); //means the gameobject has to have UIMethods attached to script
        }
    }
}
