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
                DAMAGE += 8;
            }
            DAMAGE += 8;
            //Physics2D.IgnoreLayerCollision(3, 8, true); 
            break;

            case "GER_NORMALSOL":
            //Physics2D.IgnoreLayerCollision(8, 7, true);
            DAMAGE = 8;
            break;
            case "GER_SZTURMSOL":
            //Physics2D.IgnoreLayerCollision(8, 7, true);
            DAMAGE = 11;
            break;
            case "GER_SNIPERSOL":
            //Physics2D.IgnoreLayerCollision(8, 7, true);
            DAMAGE = 12;
            break;
            case "GER_TANKSOL":
            //Physics2D.IgnoreLayerCollision(8, 7, true);
            DAMAGE = 30;
            break;
            case "Dzialko":
            gameObject.layer = LayerMask.NameToLayer("BaseProjectile");
            DAMAGE = 5; 
            break;
            case "CZOLG_ENT_POL":
            gameObject.layer = LayerMask.NameToLayer("BaseProjectile");
            DAMAGE = 35; 
            break;
            case "SNIPERSOL_POL":
            gameObject.layer = LayerMask.NameToLayer("BaseProjectile");
            DAMAGE = 9; 
            break;
            case "SZTURMSOL_POL":
            gameObject.layer = LayerMask.NameToLayer("BaseProjectile");
            DAMAGE = 11; 
            break;
        }
    }
    void OnTriggerEnter2D(Collider2D col){
       
        switch(col.gameObject.tag){
            case "MB":
  col.gameObject.GetComponent<HEALTH_SCRIPT>().Health -= 10/*(int)(30.0 / 100.0 * DAMAGE)*/; 
            Destroy(gameObject);
            
            break;
            case "enemy":
            col.gameObject.GetComponent<HEALTH_SCRIPT>().Health -= DAMAGE;
            Destroy(gameObject);
            break;
            case "Player":
            col.gameObject.transform.GetComponent<HEALTH_SCRIPT>().Health -= DAMAGE;
            Destroy(gameObject);
            break;

        }
        
    }
}
