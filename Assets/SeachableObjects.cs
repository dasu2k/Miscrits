using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SeachableObjects : MonoBehaviour
{
    public TMP_Text promt;
     public void OnTriggerEnter()
     {
        promt.text = "Press F to search for Crits";
     }
     public void OnTriggerExit()
     {
        promt.text= "";
     }
}
