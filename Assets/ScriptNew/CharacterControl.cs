using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {
    private float gravity = 9.8f;
    private float vSpeed = 0.0f;
    private float mJump = 8.0f;
    private float characterRotation = 90.0f;
    private float movement = 10.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0.0f, Input.GetAxis("Horizontal") * characterRotation * Time.deltaTime , 0.0f);
        Vector3 velocity=transform.forward * Input.GetAxis("Vertical") * movement;

        if (GetComponent<CharacterController>().isGrounded)
        {
            vSpeed = 0.0f;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                vSpeed = mJump;
            }
        }

        vSpeed -= gravity * Time.deltaTime;
        velocity.y = vSpeed;
        GetComponent<CharacterController>().Move(velocity * Time.deltaTime);
	}
}
