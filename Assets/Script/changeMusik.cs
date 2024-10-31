using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMusik : MonoBehaviour
{

    public int indexMusik;
    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.Find("BG Music") != null)
        {
             BGmusic.instance.changeMusik(indexMusik);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
