using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
 
public class SeachableObjects : MonoBehaviour
{
   public TMP_Text promt;
   private bool Searchable=false;
   
   void Update(){
      if(Searchable)
         if(Input.GetKeyDown(KeyCode.F))
            SceneManager.LoadScene("BattleScene");
   }

   public void OnTriggerEnter()
   {
     promt.text = "Press F to search for Crits";
      Searchable = true;
   }
   public void OnTriggerExit()
   {
     promt.text= "";
     Searchable= false;
   }
}
