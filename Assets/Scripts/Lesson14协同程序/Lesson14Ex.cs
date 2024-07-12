using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14Ex : MonoBehaviour
{
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateCube(100000));
    }

    IEnumerator CreateCube(int num)
    {
        for (int i = 0; i < num; i++)
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obj.transform.position = new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), Random.Range(-100, 100));
            if (i%1000==0)
            {
                yield return null;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MyCoroutine()
    {
        while (true)
        {
            print(time);
            ++time;
            yield return new WaitForSeconds(1);
        }
    }
}
