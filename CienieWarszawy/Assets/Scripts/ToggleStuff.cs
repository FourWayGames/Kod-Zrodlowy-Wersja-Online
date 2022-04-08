using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class ToggleStuff : MonoBehaviour, ISelectHandler
{
    Button _Button;
   public static Button PreviousSelected;
    
    void Start()
    {
        _Button = gameObject.GetComponent<Button>();
    }

   void Update(){
     
   }
   

    public void OnSelect(BaseEventData eventData)
     {
         if(PreviousSelected != null){
           
           PreviousSelected.interactable = true;
         }
                           PreviousSelected = gameObject.GetComponent<Button>();
         
          
         _Button.interactable = false;
         
     }
}
