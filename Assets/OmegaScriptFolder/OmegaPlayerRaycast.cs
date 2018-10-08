using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OmegaPlayerRaycast : MonoBehaviour {
    private bool doorClosed = true;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(transform.position, transform.forward * 10, Color.green);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Door"))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 15.0f) && doorClosed)
                {
                doorClosed = false;
                GameObject.Find("Left").transform.Translate(-5.0f, 0.0f, 0.0f);
                GameObject.Find("Right").transform.Translate(5.0f, 0.0f, 0.0f);
            }

        }
    }
}
