using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOmegaMovement : MonoBehaviour {
    private float movementSpeed = 10.0f;

	// Use this for initialization
	void Start () {
        transform.Rotate(new Vector3(0.0f, 90.0f, 0.0f));
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.position += transform.right * Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;

        transform.Rotate(new Vector3(0.0f, 90.0f, 0.0f) * Time.deltaTime * Input.GetAxis("Roll"));
	}
}
