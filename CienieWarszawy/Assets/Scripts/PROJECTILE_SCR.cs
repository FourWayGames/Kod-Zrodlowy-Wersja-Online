using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PROJECTILE_SCR : MonoBehaviour
{
    private int DAMAGE;
    void Start()
    {
        
        switch(gameObject.transform.parent.name){
            case "POL_NORMALSOL":
            var OurGuy = gameObject.transform.parent;
            if(OurGuy.GetComponent<AI_CONTROLLER>().AtkBoost){
                DAMAGE += 20;
            }
            DAMAGE += 20;
            //Physics2D.IgnoreLayerCollision(3, 8, true); 
            break;

            case "GER_NORMALSOL":
            //Physics2D.IgnoreLayerCollision(8, 7, true);
            DAMAGE = 10;
            break;
            case "Dzialko":
            gameObject.layer = LayerMask.NameToLayer("BaseProjectile");
            DAMAGE = 5; 
            break;
        }
    }
    void OnTriggerEnter2D(Collider2D col){
       
        switch(col.gameObject.tag){
            case "MB":
  col.gameObject.GetComponent<HEALTH_SCRIPT>().Health -= (int)(30.0 / 100.0 * DAMAGE); 
            Destroy(gameObject);
            
            break;
            case "enemy":
            col.gameObject.GetComponent<HEALTH_SCRIPT>().Health -= DAMAGE;
            Destroy(gameObject);
            break;
            case "Player":
            col.gameObject.GetComponent<HEALTH_SCRIPT>().Health -= DAMAGE;
            Destroy(gameObject);
            break;

        }
        
    }
}
