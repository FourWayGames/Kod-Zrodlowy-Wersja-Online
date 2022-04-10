using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PROJECTILE_SCR : MonoBehaviour
{
    private int DAMAGE;
    void Start()
    {
        
        switch(gameObject.transform.parent.name){
            case "PISTOLSOL_POL":
            var OurGuy = gameObject.transform.parent;
            if(OurGuy.GetComponent<AI_CONTROLLER>().AtkBoost){
                DAMAGE += 5;
            }
            DAMAGE += 5;
            //Physics2D.IgnoreLayerCollision(3, 8, true); 
            break;

            case "GER_NORMALSOL":
            //Physics2D.IgnoreLayerCollision(8, 7, true);
            DAMAGE = 3;
            break;
            case "Dzialko":
            gameObject.layer = LayerMask.NameToLayer("BaseProjectile");
            DAMAGE = 5; 
            break;
            case "CZOLG_ENT_POL":
            gameObject.layer = LayerMask.NameToLayer("BaseProjectile");
            DAMAGE = 75; 
            break;
            case "SNIPERSOL_POL":
            gameObject.layer = LayerMask.NameToLayer("BaseProjectile");
            DAMAGE = 40; 
            break;
            case "SZTURMSOL_POL":
            gameObject.layer = LayerMask.NameToLayer("BaseProjectile");
            DAMAGE = 10; 
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
