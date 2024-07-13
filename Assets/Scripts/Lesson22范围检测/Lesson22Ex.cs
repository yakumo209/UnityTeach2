using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson22Ex : MonoBehaviour
{
    public float moveSpeed=5;

    public float rotateSpeed=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private Collider[] colliders;
    void Update()
    {
        transform.Rotate(Vector3.up,Input.GetAxis("Horizontal")*rotateSpeed*Time.deltaTime);
        transform.Translate(Vector3.forward*Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.J))
        {
            colliders = Physics.OverlapBox(transform.position + transform.forward, Vector3.one*.5f,transform.rotation,
                1<<LayerMask.NameToLayer("Monster"));
            for (int i = 0; i < colliders.Length; i++)
            {
                print(colliders[i].name+"hurt");
            }
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            colliders = Physics.OverlapCapsule(transform.position, transform.position + transform.forward*5, 0.5f,
                1 << LayerMask.NameToLayer("Monster"));
            
            for (int i = 0; i < colliders.Length; i++)
            {
                print(colliders[i].name+"hurt");
            }
            
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            colliders = Physics.OverlapSphere(transform.position, 10, 1 << LayerMask.NameToLayer("Monster"));
            for (int i = 0; i < colliders.Length; i++)
            {
                print(colliders[i].name+"hurt");
            }
        }
    }
}
