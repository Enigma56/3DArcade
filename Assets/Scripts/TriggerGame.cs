using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerGame : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        
        /*Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("BlockStack"))
        {
            Debug.Log("spaghetti!");
        }*/

        //Only player is colliding, no need to check "other"
        var gameTag = gameObject.tag;
        switch (gameTag)
        {
            case "BlockStack":
                Debug.Log("blockstack loaded!");
                SceneManager.LoadScene("BlockStack");
                break;
            case "SkiBall":
                Debug.Log("skiball loaded!");
                break;
            case "SpaceShooter":
                Debug.Log("galaga loaded!");
                break;
            case "Pong":
                SceneManager.LoadScene("Pong");
                Debug.Log("pong loaded!");
                break;
            
        }
        //Debug.Log("start game!");
        
        //get portal tag
        //load respective scene through Scenemanager
    }
}
