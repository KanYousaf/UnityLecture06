using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLerpTop : MonoBehaviour {

    private Transform mTargetTransform;
    private Vector3 offset;
    private float smoothing = 3.0f;

    // Use this for initialization
    void Start()
    {
        offset = new Vector3(-50.0f, 14.0f, 0.0f);
        mTargetTransform = GameObject.Find("GameCharacter").transform;
    }


    void LateUpdate()
    {
        Vector3 targetVectorPosition = mTargetTransform.position + offset;
        transform.LookAt(mTargetTransform);
        transform.position = Vector3.Lerp(transform.position, targetVectorPosition, smoothing * Time.deltaTime);
    }
}
