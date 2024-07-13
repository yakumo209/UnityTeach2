using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ResourcesMgr
{
    private static ResourcesMgr instance=new ResourcesMgr();
    public static ResourcesMgr Instance => instance;

    private ResourcesMgr()
    {
        
    }

    public void LoadRes<T>(string name, UnityAction<T> callBack) where T : Object
    {
        
        ResourceRequest rq= Resources.LoadAsync<T>(name);
        rq.completed += (a) =>
        {
            callBack((a as ResourceRequest).asset as T);
        };
    }
}
