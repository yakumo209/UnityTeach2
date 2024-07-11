using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Quaternion q = new Quaternion(Mathf.Sin(30*Mathf.Deg2Rad) , 0, 0, Mathf.Cos(30* Mathf.Deg2Rad));
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.transform.rotation = q;
        Quaternion q2= Quaternion.AngleAxis(180, Vector3.right);
        obj.transform.rotation = q2;
        Quaternion q3 = Quaternion.Euler(60, 0, 0);
        obj.transform.rotation = q3;
        print(q3.eulerAngles);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation *= Quaternion.AngleAxis( 1, Vector3.up);
    }
}
