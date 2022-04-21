using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlockStack
{
    public class MoveBlock : MonoBehaviour
    {
        private float blockSpeed;
        
        public GameObject parentObject;
        
        //private Rigidbody cubeRB;
        private SpawnBlock blockUtils;
        
        private Vector3 cubeMovement;
        // Start is called before the first frame update
        void Start()
        {
            //cubeRB = GetComponent<Rigidbody>();
            blockUtils = GetComponentInParent<SpawnBlock>();

            blockSpeed = blockUtils.Speed;
            cubeMovement = Vector3.right;
        }
        
        void Update()
        {
            
            transform.Translate(cubeMovement * Time.deltaTime * blockSpeed);
            
            if(Input.GetKeyDown(KeyCode.Space))
            {

                //generate block and attach it to parent object
                blockUtils.GenerateBlock(transform.position.x, transform.position.z, parentObject);

                Vector3 newPosition = Vector3.up * blockUtils.PlacementHeight;
                transform.position = newPosition;
            }
        }

        
        void OnCollisionEnter(Collision other)
        {
            cubeMovement = cubeMovement == Vector3.right ? Vector3.left : Vector3.right;
            

        }
    }   
}
