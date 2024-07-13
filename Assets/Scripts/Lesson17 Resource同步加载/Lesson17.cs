using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj= Resources.Load("Cube") as GameObject;
        Instantiate(obj,Vector3.zero, transform.rotation);
        
        TextAsset txt = Resources.Load<TextAsset>("Txt/新建文本文档");
        print(txt.text);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
