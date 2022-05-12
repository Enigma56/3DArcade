using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MoveBall : MonoBehaviour
{
    public float currentBallSpeed;
    private float initialBallSpeed;
    // Start is called before the first frame update
    private Rigidbody ballRB;
    private Vector3 startingLocation;
    void Awake()
    {
        ballRB = GetComponent<Rigidbody>();
        startingLocation = transform.position;
    }

    private void Start()
    {
        initialBallSpeed = currentBallSpeed;
        AddStartingForce();
    }

    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);
        
        ballRB.AddForce(new Vector3(x,y,0) * currentBallSpeed);
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Paddle1") || other.gameObject.CompareTag("Paddle2"))
            ballRB.velocity *= 1.1f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ScoreLeft"))
        {
            SingletonPong.Instance.playerTwoScore++;
            SingletonPong.Instance.playerTwoScoreText.text = SingletonPong.Instance.playerTwoScore.ToString();
            
            Debug.Log("player 2 scores!!");    
        }
        else if(other.gameObject.CompareTag("ScoreRight"))
        {
            SingletonPong.Instance.playerOneScore++;
            SingletonPong.Instance.playerOneScoreText.text = SingletonPong.Instance.playerOneScore.ToString();
            Debug.Log("player 1 scores!!");    
        }

        ballRB.velocity = Vector3.zero;
        transform.position = startingLocation;
        currentBallSpeed = initialBallSpeed;
        AddStartingForce();
    }
}
