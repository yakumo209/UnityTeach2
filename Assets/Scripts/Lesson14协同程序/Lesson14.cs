using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Random = System.Random;

public class Lesson14 : MonoBehaviour
{
    private Thread t;

    private Queue<Vector3> Queue = new Queue<Vector3>();
    // Start is called before the first frame update
    void Start()
    {
        t = new Thread(Test);
        // t.Start();
        Coroutine c= StartCoroutine(MyCoroutine(1, "str"));
        StartCoroutine(MyCoroutine(1, "str"));
        StartCoroutine(MyCoroutine(1, "str"));
        StopCoroutine(c);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Queue.Count>0)
        {
            this.transform.position = Queue.Dequeue();
        }
    }

    private void Test()
    {
        while (true)
        {
            Random r = new Random();    
            Queue.Enqueue(new Vector3(r.Next(-10,10),1,1));
            Thread.Sleep(1000);
            print("新开线程");
        }
    }

    private void OnDestroy()
    {
        t.Abort();
        t = null;
    }

    IEnumerator MyCoroutine(int i, string str)
    {
        print(i);
        yield return 2;
        print(str);
        while (true)
        {
            print("TURE");
            yield return new WaitForSeconds(1);
            yield break;
        }
    }

}
