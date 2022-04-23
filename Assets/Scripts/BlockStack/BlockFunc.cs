using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlockStack
{
    public class BlockFunc : MonoBehaviour
    {
        public float blockSpeed;

        public Camera gameCamera;
        public GameObject parentObject;

        private AudioSource collisionSound;
        private SpawnBlock blockUtils;
        
        private Vector3 cubeMovement;
        // Start is called before the first frame update
        void Start()
        {
            collisionSound = GetComponent<AudioSource>();
            blockUtils = GetComponentInParent<SpawnBlock>();
            
            cubeMovement = Vector3.right;
        }
        
        void Update()
        {
            transform.Translate(cubeMovement * Time.deltaTime * blockSpeed);
            
            if(Input.GetKeyDown(KeyCode.Space))
            {
                blockUtils.GenerateBlock(transform.position.x, transform.position.z, parentObject);

                Vector3 newBlockPosition = Vector3.up * blockUtils.PlacementHeight;
                transform.position = newBlockPosition;

                Vector3 newCameraPosition = new Vector3(gameCamera.transform.position.x, gameCamera.transform.position.y + 2, gameCamera.transform.position.z);
                gameCamera.transform.position = newCameraPosition;

                blockSpeed += .5f;
            }
        }

        
        void OnCollisionEnter(Collision other)
        {
            cubeMovement = cubeMovement == Vector3.right ? Vector3.left : Vector3.right;
            collisionSound.PlayOneShot(collisionSound.clip);
        }
    }   
}
