using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallMove : MonoBehaviour
{
    Vector3 moveDirection;

    float moveSpeed = 5;

    Rigidbody fireBallBody;

    // Start is called before the first frame update
    void Start()
    {
	fireBallBody = this.gameObject.GetComponent<Rigidbody>();

	moveDirection = new Vector3(-1, 0, 0);

	fireBallBody.velocity = moveDirection;

	fireBallBody.velocity *= moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
