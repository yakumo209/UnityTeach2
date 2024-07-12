using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove2 : MonoBehaviour
{
    public Transform target;

    public float headOffsetH=1;

    public float angle;

    public float dis = 5;

    public float minDis = 3;
    public float maxDis = 10;

    private Vector3 nowPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private Vector3 nowDir;
    void Update()
    {
        dis+=Input.GetAxis("Mouse ScrollWheel");
        dis = Mathf.Clamp(dis, minDis, maxDis);
        nowPos = target.position + target.up * headOffsetH;
        nowDir = Quaternion.AngleAxis(angle, Vector3.right) * -target.forward;
        nowPos = nowPos + nowDir*dis;
        transform.position = nowPos;
        Debug.DrawLine(transform.position,target.position+target.up*headOffsetH,Color.green);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(-nowDir), Time.deltaTime);
    }
}
