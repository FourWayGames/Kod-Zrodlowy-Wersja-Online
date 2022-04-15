using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UI_Handler : MonoBehaviour, ISelectHandler/*, IDeselectHandler*/, IPointerEnterHandler, IPointerExitHandler 
{    
public AudioSource d;
    public void Start(){
        transform.GetChild(0).GetComponent<Text>().color = Color.gray;
    }

    public void OnSelect(BaseEventData eventData)
     {
                  
        //gameObject.transform.localScale = new Vector2(1.3f, 1.3f);
        
     }

      //public void OnDeselect(BaseEventData eventData)
     //{
       //          gameObject.transform.localScale = new Vector2(1f, 1f);
     //}

    public void OnPointerEnter(PointerEventData eventData)
     {
       d.Play();
       
     }
     public void OnPointerExit(PointerEventData eventData){
      
     
     }
     
}
