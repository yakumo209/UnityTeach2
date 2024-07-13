using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson18Test : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject obj;
    void Start()
    {
        ResourcesMgr.Instance.LoadRes<GameObject>("Cube", (o) => { obj = o; });
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (obj!=null)
            {
                Instantiate(obj);
            }
        }
    }
}
