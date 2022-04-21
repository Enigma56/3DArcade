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
        if (blockUtils.StackHeight == 1) return;
        if (other.gameObject.CompareTag("Floor"))
        {
                #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
                #endif
            Application.Quit();
            Debug.Log("touched floor!");
        }
    }
}
}