using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson15Ex : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CoroutineManager.Instance.MyStartCoroutine(Test());
    }
    IEnumerator Test()
    {
        print("1");
        yield return 1;
        print("2");
        yield return 2;
        print("3");
        yield return 3;
        print("4");
        yield return 4;
        print("5");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
