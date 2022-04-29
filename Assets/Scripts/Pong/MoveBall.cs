using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float ballSpeed;
    // Start is called before the first frame update
    private Vector3 ballMovement;
    void Start()
    {
        ballMovement = Vector3.right;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(ballMovement * Time.deltaTime * ballSpeed);
    }
    
    void OnCollisionEnter(Collision other)
    {
        ballMovement = ballMovement == Vector3.right ? Vector3.left : Vector3.right;
    }
}
