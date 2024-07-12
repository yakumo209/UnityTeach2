using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson13Ex : MonoBehaviour
{
    private int time=0;
    // Start is called before the first frame update
    void Start()
    {
        Delay2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Delay()
    {
        print(time);
        ++time;
    }
    private void Delay2()
    {
        print(time);
        ++time;
        Invoke("Delay2",1);
    }
}
