using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace BlockStack
{
    public sealed class StackListener : EventListener
    {
        protected override void Update()
        {
            base.Update();
            BlockstackSingleton.Instance.IncreaseScore();
        }
    }   
}
