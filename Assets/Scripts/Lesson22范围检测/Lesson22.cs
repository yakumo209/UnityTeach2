using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson22 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Collider[] colliders=Physics.OverlapBox(Vector3.zero, Vector3.one, Quaternion.AngleAxis(45, Vector3.up),
            1<<LayerMask.NameToLayer("UI")|
            1<<LayerMask.NameToLayer("Default"),QueryTriggerInteraction.UseGlobal);
        for (int i = 0; i < colliders.Length; i++)
        {
            print(colliders[i].name);
        }


        if (Physics.OverlapBoxNonAlloc(Vector3.zero, Vector3.one, colliders) != 0)
        {
            
        }

        colliders=Physics.OverlapSphere(Vector3.zero, 5, 1 << LayerMask.NameToLayer("Default"),
            QueryTriggerInteraction.UseGlobal);
        for (int i = 0; i < colliders.Length; i++)
        {
            print(colliders[i].name);
        }

        if (Physics.OverlapSphereNonAlloc(Vector3.zero,5,colliders)!=0)
        {
            
        }

        colliders=Physics.OverlapCapsule(Vector3.zero, Vector3.up, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
