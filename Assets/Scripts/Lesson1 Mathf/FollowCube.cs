using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_MoveType
{
    Method1,
    Method2
}

public class FollowCube : MonoBehaviour
{
    public Transform target;

    public float moveSpeed=3;

    private Vector3 pos;
    private Vector3 targetNowPos;
    private Vector3 startPos;

    public E_MoveType MoveType;

    private float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (MoveType)
        {
            case E_MoveType.Method1:
                pos = transform.position;
                pos.x = Mathf.Lerp(pos.x, target.position.x, Time.deltaTime * moveSpeed);
                pos.y = Mathf.Lerp(pos.y, target.position.y, Time.deltaTime * moveSpeed);
                pos.z = Mathf.Lerp(pos.z, target.position.z, Time.deltaTime * moveSpeed);
                transform.position = pos;
                break;
            case E_MoveType.Method2:
                if (targetNowPos != target.position)
                {
                    time = 0;
                    targetNowPos = target.position;
                    startPos = transform.position;
                }

                time += Time.deltaTime;
                pos = transform.position;
                pos.x = Mathf.Lerp(startPos.x, targetNowPos.x, time);
                pos.y = Mathf.Lerp(startPos.y, targetNowPos.y, time);
                pos.z = Mathf.Lerp(startPos.z, targetNowPos.z, time);
                transform.position = pos;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        
    }
}
