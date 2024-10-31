using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creditScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.Find("BG Music") != null)
        {
            BGmusic.instance.MusikStop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
