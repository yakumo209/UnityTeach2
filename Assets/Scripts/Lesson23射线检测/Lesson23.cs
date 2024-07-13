using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson23 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Ray r = new Ray(Vector3.right, Vector3.forward);
        print(r.origin);
        print(r.direction);
        

        Ray r3 = new Ray(Vector3.zero, Vector3.forward);
        if (Physics.Raycast(r3, 1000, 1 << LayerMask.NameToLayer("Monster")))
        {
            print("Hit something");
        }
        if (Physics.Raycast(Vector3.zero,Vector3.forward, 1000, 1 << LayerMask.NameToLayer("Monster")))
        {
            print("Hit something2");
        }

        if (Physics.Raycast(r3,out hit,1000,1<<LayerMask.NameToLayer("Monster")))
        {
            print(hit.collider.name+hit.point+hit.normal);
            print(hit.transform.position);
            print(hit.distance);
        }

        hits = Physics.RaycastAll(r3, 1000, 1 << LayerMask.NameToLayer("Monster"));
        for (int i = 0; i < hits.Length; i++)
        {
            print(hits[i].collider.name);
        }

        
    }
    RaycastHit hit;
    RaycastHit[] hits;
    // Update is called once per frame
    void Update()
    {
        Ray r2 = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.RaycastNonAlloc(r2, hits,1000,1<<LayerMask.NameToLayer("Monster"))>0)
        {
            for (int i = 0; i < hits.Length; i++)
            {
                print(hits[i].collider.name);
            }
        }
    }
}
