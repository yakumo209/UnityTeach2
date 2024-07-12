using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Delay",5);
        InvokeRepeating("Delay",5,1);

        if (IsInvoking())
        {
            print("exsist");
        }
    }

    private void Delay()
    {
        print("Delay for 5 ");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
