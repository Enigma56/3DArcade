using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Block") || BlockstackSingleton.Instance.StackHeight == 0)
            BlockstackSingleton.Instance.IncreaseStackHeight();
    }
}
