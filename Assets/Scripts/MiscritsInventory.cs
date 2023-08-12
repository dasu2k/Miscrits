using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MiscritsInventory : MonoBehaviour
{
    public GameObject plane;

    public void Update(){
        if(Input.GetKeyDown(KeyCode.C))
        {    
            plane.SetActive(!plane.activeSelf);
        }
    }
}