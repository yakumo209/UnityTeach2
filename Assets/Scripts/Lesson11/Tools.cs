using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Tools
{
    public static void MyLookAt(this Transform obj,Transform target)
    {
        Vector3 vec = target.position - obj.position;
        Quaternion q = Quaternion.LookRotation(vec);
        obj.rotation = q;
    }
}
