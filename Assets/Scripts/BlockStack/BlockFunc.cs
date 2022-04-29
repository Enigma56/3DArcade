using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

namespace BlockStack
{
    public class BlockFunc : MonoBehaviour
    {
        public float blockSpeed;
        
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

            if (Input.GetKeyDown(KeyCode.Space))
            {
                blockUtils.GenerateBlock(transform.position.x, transform.position.z, parentObject);

                Vector3 newBlockPosition = new Vector3(1  * UnityEngine.Random.Range(-6,6),1 * blockUtils.PlacementHeight,0);
                transform.position = newBlockPosition;
                
                SingletonBS.Instance.MoveCamera();

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
