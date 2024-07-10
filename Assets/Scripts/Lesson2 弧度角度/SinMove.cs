using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMove : MonoBehaviour
{
    public float moveSpeed=5;

    public float changeSpeed = 2;

    public float changeSize = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float time;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
        time += Time.deltaTime*changeSpeed ;
        transform.Translate(Vector3.right*changeSize*Time.deltaTime*Mathf.Sin(time));
    }
}
