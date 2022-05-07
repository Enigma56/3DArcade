using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBounds : MonoBehaviour
{
    public Camera mainCamera;
    private BoxCollider screenCollider;
    private float teleportOffset;

    private void Awake()
    {
        screenCollider = GetComponent<BoxCollider>();
    }

    private void Start()
    {
        teleportOffset = 0.2f;
        UpdateBounds();
    }

    private void UpdateBounds()
    {
        float height = mainCamera.orthographicSize * 2;

        var colliderSize = new Vector3(height * mainCamera.aspect, height, 10);
        screenCollider.size = colliderSize;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("ship off screen!");
    }
}
