using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Mathf.PI);
        print(Mathf.Abs(-20));
        print(Mathf.Abs(1));
        float f = 1.3f;
        print(Mathf.CeilToInt(f));
        print(Mathf.FloorToInt(f));
        print(Mathf.Clamp(10,3,8));
    }

    private float start = 0;

    private float result;

    private float time;
    // Update is called once per frame
    void Update()
    {
        // start = Mathf.Lerp(start, 10, Time.deltaTime);
        // print("start:"+start);
        time += Time.deltaTime;
        result = Mathf.Lerp(start, 10, time);
        print("result"+result);
    }
}
