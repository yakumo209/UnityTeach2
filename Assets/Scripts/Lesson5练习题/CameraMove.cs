using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform target;
    private Vector3 offset=new Vector3(0,7,-4);
    private Vector3 targetPos;
    private Vector3 startPos;
    private float time;
    private Quaternion targetQ;
    private Quaternion startQ;
    private float roundTime;
    private void Start()
    {
        startPos = transform.position;
        startQ = transform.rotation;
    }

    private void LateUpdate()
    {
        if (targetPos!=target.position + target.up*7+target.forward*-4)
        {
            targetPos = target.position + target.up * 7 + target.forward * -4;
            startPos = transform.position;
            time = 0;
        }

        time += Time.deltaTime;
        // transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime); 
        transform.position = Vector3.Lerp(startPos, targetPos, time);
        // transform.LookAt(target);
        targetQ = Quaternion.LookRotation(target.position - transform.position);
        // transform.rotation = Quaternion.Slerp(transform.rotation, targetQ, Time.deltaTime);
        roundTime += Time.deltaTime;
        if (targetQ!=Quaternion.LookRotation(target.position - transform.position))
        {
            roundTime = 0;
            targetQ = Quaternion.LookRotation(target.position - transform.position);
            startQ = transform.rotation;
        }
        transform.rotation = Quaternion.Slerp(startQ, targetQ, roundTime);
    }
}
