using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoNotDestroy : MonoBehaviour
{
    public loadLevel loadLevel;
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        if( musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

}
