using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy2 : MonoBehaviour
{
    public Transform A;

    public Transform B;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private float dot;
    private Vector3 cross;
    private float distance;
    private float angle;
    void Update()
    {
        dot = Vector3.Dot(A.forward, B.position - A.position);
        cross = Vector3.Cross(A.forward, B.position - A.position);
        distance = Vector3.Distance(A.position, B.position);
        angle = Vector3.Angle(Vector3.forward, B.position - A.position);
        // print(angle);
        Debug.DrawRay(A.position,B.position-A.position,Color.green);
        //qianhou
        // if (dot>0)
        // {
        //     if(cross .y>0)
        //     {
        //         print("youqian");
        //     }
        //     else
        //     {
        //         print("zuoqian");
        //     }
        // }
        // else
        // {
        //     if (cross.y>0)
        //     {
        //         print("youhou");
        //     }
        //     else
        //     {
        //         print("zuohou");
        //     }
        // }
        /////////////////////

        if (distance<5)
        {
            if ((cross.y<0 && angle<20)||(cross.y>0&& angle<30))
            {
                print("检测到敌人");
            }
        }
    }
}
