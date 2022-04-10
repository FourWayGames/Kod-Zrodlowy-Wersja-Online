using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mina_Script : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D col){
       switch(col.gameObject.tag){
           case "enemy":
           col.gameObject.GetComponent<HEALTH_SCRIPT>().Health -= 150;
            Destroy(gameObject);
           break;
       }
   }
}
