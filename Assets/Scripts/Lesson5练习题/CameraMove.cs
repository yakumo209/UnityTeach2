using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform target;
    private Vector3 offset=new Vector3(0,7,-4);
    private void LateUpdate()
    {
        transform.position = target.position + target.up*7+target.forward*-4; 
        transform.LookAt(target);
    }
}
