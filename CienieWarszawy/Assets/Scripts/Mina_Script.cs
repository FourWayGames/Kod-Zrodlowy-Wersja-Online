using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mina_Script : MonoBehaviour
{
    public GameObject aa;
    public AudioSource boomer;
   void OnTriggerEnter2D(Collider2D col){
       switch(col.gameObject.tag){
           case "enemy":
           col.gameObject.GetComponent<HEALTH_SCRIPT>().Health -= 150;
            StartCoroutine(DestroyEet());
           break;
       }
   }

   IEnumerator DestroyEet(){
      boomer.Play();
      aa.SetActive(false);
       yield return new WaitForSeconds(1f);
       Destroy(gameObject);
   }
}
