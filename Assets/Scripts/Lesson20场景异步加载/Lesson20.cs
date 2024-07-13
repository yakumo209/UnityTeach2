using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lesson20 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        // AsyncOperation ao= SceneManager.LoadSceneAsync("Lesson20Test");
        // ao.completed += (a) =>
        // {
        //     print("加载结束");
        // };
        StartCoroutine(Load("Lesson20Test"));
    }

    IEnumerator Load(string name)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(name);
        while (!ao.isDone)
        {
            print(ao.priority);
            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
