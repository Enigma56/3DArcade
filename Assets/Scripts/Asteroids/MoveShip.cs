using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    private Rigidbody shipRB;
    
    void Start()
    {
        shipRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            shipRB.AddForce(new Vector3(0, 1.0f, 0));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            shipRB.AddForce(new Vector3(0, -1.0f, 0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            shipRB.AddForce(new Vector3(1.0f, 0, 0));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            shipRB.AddForce(new Vector3(-1.0f, 0, 0));
        }
    }
}
