using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson18 : MonoBehaviour
{
    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        // ResourceRequest rq= Resources.LoadAsync<GameObject>("Cube");
        // rq.completed += LoadOver;
        StartCoroutine(Load());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // private void LoadOver(AsyncOperation rq)
    // {
    //     print("加载结束");
    //     obj = (rq as ResourceRequest).asset as GameObject;
    //     Instantiate(obj);
    // }

    IEnumerator Load()
    {
        ResourceRequest rq = Resources.LoadAsync<GameObject>("Cube");
        while (!rq.isDone)
        {
            print(rq.priority);
            yield return null;
        }
        obj=rq.asset as GameObject;
    }
}
