using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    public Transform A;

    public Transform B;
    // Start is called before the first frame update
    void Start()
    {
        Vector3.Cross(A.position, B.position);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 C = Vector3.Cross(A.position, B.position);
        if (C.y>0)
        {
            print("B在A右侧");
        }
        else
        {
            print("B在A左侧");
        }
    }
}
