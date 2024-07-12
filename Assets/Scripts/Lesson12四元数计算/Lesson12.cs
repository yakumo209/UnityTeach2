using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Quaternion q = Quaternion.AngleAxis(20, Vector3.up);
        transform.rotation *= q;

        Vector3 v = Vector3.forward;
        print(v);
        v = Quaternion.AngleAxis(90, Vector3.up) * v;
        print(v);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
