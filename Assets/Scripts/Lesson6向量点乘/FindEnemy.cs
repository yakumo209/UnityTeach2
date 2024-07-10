using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour
{
    public Transform target;

    private float angle;

    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position,target.position-transform.position);
        angle= Vector3.Angle(transform.forward, target.position - transform.position);
        distance = Vector3.Distance(target.position, transform.position);
        // print(angle);
        // print(distance);
        if (angle < 22.5 && distance < 5)
        {
            print("45 find enenmy");
        }
    }
}
