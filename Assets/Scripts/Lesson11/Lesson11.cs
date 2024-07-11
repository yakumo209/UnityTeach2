using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{

    public Transform testObj;


    public Transform target;

    public Transform A;

    public Transform B;

    private Quaternion start;
    private Quaternion end;

    private float time;

    public Transform lookA;

    public Transform lookB;
    // Start is called before the first frame update
    void Start()
    {
        print(Quaternion.identity);
        Instantiate(testObj, Vector3.zero, Quaternion.identity);
        start = B.transform.rotation;
        
    }

    // Update is called once per frame
    void Update()
    {
        A.transform.rotation = Quaternion.Slerp(A.transform.rotation, target.transform.rotation, Time.deltaTime);
        time += Time.deltaTime;
        if (end!=target.rotation)
        {
            time = 0;
            start = B.rotation;
            end = target.rotation;
        }
        B.transform.rotation = Quaternion.Slerp(start, end, time);
        
        
        lookA.MyLookAt(lookB);
    }
}
