using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerPad : MonoBehaviour
{
    public float paddleSpeed;

    private bool isCollidingAtTop;
    private bool isCollidingAtBottom;

    private void Start()
    {
        isCollidingAtTop = false;
        isCollidingAtTop = false;
    }

    void Update()
    {
        movePaddles();
    }

    void movePaddles()
    {
        if (gameObject.tag.Equals("Paddle1"))
        {
            if (Input.GetKey(KeyCode.W) && !isCollidingAtTop)
            {
                transform.Translate(0,  paddleSpeed * Time.deltaTime, 0);
            }
            
            else if (Input.GetKey(KeyCode.S) && !isCollidingAtBottom)
            {
                transform.Translate(0, -paddleSpeed * Time.deltaTime, 0);
            }
           
        }
        
        if (gameObject.tag.Equals("Paddle2"))
        {
            if (Input.GetKey(KeyCode.UpArrow) && !isCollidingAtTop)
            {
                transform.Translate(0,  paddleSpeed * Time.deltaTime, 0);
            }
            
            else if (Input.GetKey(KeyCode.DownArrow) && !isCollidingAtBottom)
            {
                transform.Translate(0, -paddleSpeed * Time.deltaTime, 0);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("TopBoundPong"))
        {
            isCollidingAtTop = true;
            isCollidingAtBottom = false;
        }
        
        else if (other.gameObject.CompareTag("BottomBoundPong"))
        {
            isCollidingAtTop = false;
            isCollidingAtBottom = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        isCollidingAtTop = false;
        isCollidingAtBottom = false;
    }
}
