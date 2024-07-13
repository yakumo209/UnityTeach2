using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson23EX : MonoBehaviour
{
    private Transform now;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private RaycastHit info;
    void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        // {
        //     if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out info,
        //             1000,1<<LayerMask.NameToLayer("Monster")))
        //     {
        //         GameObject obj = Instantiate(Resources.Load<GameObject>("Eff/HitEff"));
        //         obj.transform.position = info.point+info.normal*0.5f;
        //         obj.transform.rotation = Quaternion.LookRotation(info.normal);
        //         Destroy(obj,0.8f);
        //         GameObject obj2 = Instantiate(Resources.Load<GameObject>("Eff/Hole"));
        //         obj2.transform.position = info.point+info.normal*0.5f;
        //         obj2.transform.rotation = Quaternion.LookRotation(info.normal);
        //     }
        // }
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out info,1000,1<<LayerMask.NameToLayer("Monster")))
            {
                now = info.transform;
                print("选中"+now.name);
            }
            else
            {
                now = null;
                print("取消选中");
            }
            
        }

        if (Input.GetMouseButton(0)&&now!=null)
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out info,1000,1<<LayerMask.NameToLayer("UI")))
            {
                now.position = info.point+info.normal*0.5f;
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            now = null;
            print("取消选中");
        }
    }
}
