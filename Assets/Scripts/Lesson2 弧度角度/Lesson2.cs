using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float rad = 1;
        print(rad*Mathf.Rad2Deg);
        print(rad*Mathf.Deg2Rad);
        print(Mathf.Sin(30*Mathf.Deg2Rad));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
