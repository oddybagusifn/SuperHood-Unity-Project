using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondScore : MonoBehaviour
{
    public static int hitungDiamond;
    Text hitungDiamondText;
    
    // Start is called before the first frame update
    void Start()
    {
        hitungDiamond = 0;
        hitungDiamondText = GetComponent<Text> ();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        hitungDiamondText.text = hitungDiamond.ToString();
        
    }
}
