using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace BlockStack
{
    public class SingletonBS : MonoBehaviour
    {
        public static SingletonBS Instance { get; private set; }
        public int StackHeight { get; private set; }
    
        public Camera gameCamera;
        //private bool cameraIsMoving = false;
        private Queue<IEnumerator> cameraMovementQueue = new Queue<IEnumerator>();
        public TextMeshProUGUI HeightText;

        private void Awake()
        {
            if (Instance != null && Instance != this) 
            { 
                Destroy(this); 
            } 
            else 
            { 
                Instance = this; 
            }

            StartCoroutine(CoroutineCoordinator());
        }

        IEnumerator CoroutineCoordinator() //runs infinitely until program stops
        {
            while (true)
            {
                while (cameraMovementQueue.Count > 0)
                {
                    yield return StartCoroutine(cameraMovementQueue.Dequeue());
                }
                yield return null;
            }
        }

        public void MoveCamera()
        {
            cameraMovementQueue.Enqueue(SmoothCameraFollow());
        }

        private IEnumerator SmoothCameraFollow()
        {
            float duration = .2f; //Length matters for queueing up camera movement
            
            float timeElapsed = 0f;
            Vector3 newCameraPosition = new Vector3(gameCamera.transform.position.x,
                gameCamera.transform.position.y + 2, gameCamera.transform.position.z);

            while (timeElapsed < duration)
            {
                gameCamera.transform.position = Vector3.Lerp(gameCamera.transform.position, newCameraPosition, timeElapsed / duration);
                timeElapsed += Time.deltaTime;
                
                yield return null;
            }

            gameCamera.transform.position = newCameraPosition;
            
        }

        public void IncreaseStackHeight()
        {
            StackHeight++;
        }

        public void IncreaseScore()
        {
            Instance.HeightText.text = Instance.StackHeight.ToString();
        }
    }
}

