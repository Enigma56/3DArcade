using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BlockStack
{
    public class BehaviorDetection : MonoBehaviour
    {
        private SpawnBlock blockUtils;

        private void Start()
        {
            blockUtils = GetComponentInParent<SpawnBlock>();
        }

        private void OnCollisionEnter(Collision other)
        {
            Debug.Log(other.gameObject.tag);
            if (other.gameObject.CompareTag("Floor") && SingletonBS.Instance.StackHeight > 0)
            {
                #if UNITY_EDITOR
                    //UnityEditor.EditorApplication.isPlaying = false;
                    SceneManager.LoadScene("Lobby");
                #endif
                    //For final build
                    //Application.Quit();
            }
            Destroy(GetComponent<Counter>());
        }

        private void OnTriggerExit(Collider other)
        {
            SingletonBS.Instance.ScaleWallHeight();
            Debug.Log("Increase the wall height here!");
        }
    }
}