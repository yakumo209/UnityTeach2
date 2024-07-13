using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneMgr
{
    private static SceneMgr instace = new SceneMgr();
    public static SceneMgr Instance => instace;

    private SceneMgr()
    {
        
    }

    public void LoadScene(string name, UnityAction action)
    {
        AsyncOperation ao=SceneManager.LoadSceneAsync(name);
        ao.completed+= (a) =>
        {
            action();
        };
    }
}
