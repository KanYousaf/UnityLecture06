using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerToFollowbyCamera : MonoBehaviour {
    private Transform mTargetPlayer;
    private float smoothingFactor = 3.0f;
    Vector3 offset;

    // Use this for initialization
    void Start () {
        mTargetPlayer=GameObject.Find("Player").transform;
        offset = new Vector3(0.0f, 5.0f, -10.0f);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targetPlayerPosition = mTargetPlayer.position + offset;
        transform.LookAt(mTargetPlayer);
        transform.position = Vector3.Lerp(transform.position, targetPlayerPosition, smoothingFactor * Time.deltaTime);
	}
}
