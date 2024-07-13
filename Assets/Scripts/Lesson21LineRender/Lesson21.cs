using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson21 : MonoBehaviour
{

    private Material m;
    private LineRenderer lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
        m = Resources.Load<Material>("New Material");
        GameObject obj = new GameObject();
        obj.name = "line";
        lineRenderer=obj.AddComponent<LineRenderer>();
        lineRenderer.loop = false;
        lineRenderer.startWidth = 0.02f;
        lineRenderer.endWidth = 0.02f;
        lineRenderer.startColor=Color.cyan;
        lineRenderer.endColor=Color.blue;
        lineRenderer.material = m;
        lineRenderer.positionCount = 4;
        lineRenderer.SetPositions(new Vector3[]
        {
            new Vector3(0,0,0),
            new Vector3(0,0,5),
            new Vector3(5,0,5),
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
