using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace BlockStack
{
    
    public class SpawnBlock : MonoBehaviour
    {
        public GameObject stackCube;
        public int StackHeight { get; set; }
        public float PlacementHeight { get; set; }

        private void Start()
        {
            StackHeight = 0; //TODO: Move this to game manager object
            PlacementHeight = 3;
        }

        public void GenerateBlock(float x, float z, GameObject parent)
        {
            PlacementHeight += 2f;
            Vector3 position = new Vector3(x, PlacementHeight - 2, z);
            
            //creates a new block
            Instantiate(stackCube, position, Quaternion.identity, parent.transform);
            
        }
    }
}
