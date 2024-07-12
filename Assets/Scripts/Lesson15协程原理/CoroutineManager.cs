using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class YieldReturnTime
{

    public IEnumerator ie;
    public float time;
}

public class CoroutineManager : MonoBehaviour
{
    private static CoroutineManager instance;

    public static CoroutineManager Instance => instance;

    public List<YieldReturnTime> List = new List<YieldReturnTime>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MyStartCoroutine(IEnumerator ie)
    {
        if (ie.MoveNext())
        {
            if (ie.Current is int)
            {
                YieldReturnTime y = new YieldReturnTime();
                y.ie = ie;
                y.time=Time.time + (int)ie.Current;
                List.Add(y);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = List.Count-1; i >= 0; i--)
        {
            if (List[i].time<=Time.time)
            {
                if (List[i].ie.MoveNext())
                {
                    if (List[i].ie.Current is int)
                    {
                        List[i].time = Time.time + (int)List[i].ie.Current;
                    }
                    else
                    {
                        List.RemoveAt(i);
                    }
                }
                else
                {
                    List.RemoveAt(i);
                }
            }
        }
    }
}
