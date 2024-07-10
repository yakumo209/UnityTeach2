using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.DrawLine(this.transform.position,this.transform.position+transform.forward,Color.white);
        // Debug.DrawRay(transform.position,transform.forward,Color.white);
        Debug.DrawRay(transform.position,transform.forward,Color.white);
        Debug.DrawRay(transform.position,target.position-transform.position,Color.blue);
        float result= Vector3.Dot(this.transform.forward, (target.position - transform.position).normalized);
        // print(Mathf.Acos(result)*Mathf.Rad2Deg);
        float angle= Vector3.Angle(transform.forward, target.position - transform.position);
        print(angle);
    }
}
