using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson20T : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneMgr.Instance.LoadScene("Lesson20Test", () => {print("Helloworld"); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
