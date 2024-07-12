using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum E_FireType
{
    One,
    Two,
    Three,
    Round,
}


public class AirPlane : MonoBehaviour
{
    public E_FireType type;

    public GameObject bullet;

    public float timeBetween;

    private float time;

    public int roundNum=8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            type = E_FireType.One;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            type = E_FireType.Two;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            type = E_FireType.Three;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            type = E_FireType.Round;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (time>=timeBetween)
            {
                time = 0;
                Fire();
            }
        }
    }

    private void Fire()
    {
        switch (type)
        {
            case E_FireType.One:
                GameObject bulletObj = Instantiate(bullet,transform.position,transform.rotation );
                break;
            case E_FireType.Two:
                Instantiate(bullet, transform.position-transform.right*.5f, transform.rotation);
                Instantiate(bullet, transform.position+transform.right*.5f, transform.rotation);
                break;
            case E_FireType.Three:
                Instantiate(bullet,transform.position,transform.rotation*Quaternion.AngleAxis(-20,Vector3.up));
                Instantiate(bullet,transform.position,transform.rotation*Quaternion.AngleAxis(20,Vector3.up));
                break;
            case E_FireType.Round:
                float angle = 360 / roundNum;
                for (int i = 0; i < roundNum; i++)
                {
                    Instantiate(bullet, transform.position,
                        transform.rotation * Quaternion.AngleAxis(i * angle, Vector3.up));
                }
                break;
        }
    }
}
