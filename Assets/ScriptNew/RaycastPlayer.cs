using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastPlayer : MonoBehaviour {
    bool doorClosed = true;
    RaycastHit hit;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(transform.position, transform.forward * 5, Color.green);
    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name.Equals("Door"))
        {
            if(Physics.Raycast(transform.position, transform.forward, out hit, 15.0f))
            {
                doorClosed = false;
                GameObject.Find("Left").transform.Translate(-5.0f, 0.0f, 0.0f);
                GameObject.Find("Right").transform.Translate(5.0f, 0.0f, 0.0f);
            }
        }
    }
}
