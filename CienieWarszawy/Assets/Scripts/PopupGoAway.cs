using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupGoAway : MonoBehaviour
{
    
    //Kolejny mały skrypt na szybko aby usunąć sztuczny splashscreen po 5 sekundach
    void Start(){
        BUTTON_STORAGE.PopupShowed = true;
    }
    void Update()
    {
        
       Destroy(gameObject, 7);   
       
       if(Input.GetKey(KeyCode.Space)){
            BUTTON_STORAGE.PopupShowed = true;
           Destroy(gameObject);
       }     
    }

    
}
