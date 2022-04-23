using System;
using System.Collections;
using UnityEngine;

namespace BlockStack
{
    
    public class SpawnBlock : MonoBehaviour
    {
        public GameObject stackCube;
        public int StackHeight { get; set; }
        public int PlacementHeight { get; set; }

        private void Start()
        {
            StackHeight = 0; //TODO: Move this to game manager object
            PlacementHeight = 3;
        }

        void Update()
        {
        }

        public void GenerateBlock(float x, float z, GameObject parent)
        {
            StackHeight++;
            PlacementHeight += 2;
            
            Vector3 position = new Vector3(x, PlacementHeight - 2, z);
            
            Instantiate(stackCube, position, Quaternion.identity, parent.transform);

            Debug.Log(PlacementHeight);
        }
    }
}
