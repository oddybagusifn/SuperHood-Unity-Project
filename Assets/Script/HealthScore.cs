using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScore : MonoBehaviour
{
   public static int hitungHealth;
    Text hitungHealthText;
   void Start()
   {
    hitungHealth = 3;
    hitungHealthText = GetComponent<Text>();
   }

   void Update()
   {
    hitungHealthText.text = hitungHealth.ToString();
   }
}
