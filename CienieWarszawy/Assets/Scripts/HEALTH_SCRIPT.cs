using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HEALTH_SCRIPT : MonoBehaviour
{
    public int Health, FullHealth;
    public Slider HP_BAR;
    public GameObject GO;
    void Start()
    {
        FullHealth = Health;
     
        if(GO == null){
            return;
        }
        if(gameObject.tag == "MB"){
            Health = 200;
        }if(gameObject.name == "GER_NORMALSOL"){
        Health += 50; 
        }
        if(gameObject.tag != "MB" && gameObject.transform.parent.GetComponent<AI_CONTROLLER>().HPBoost){
            Health += 55;
        }
    }

    void Update()
    {
        
        if((ManagerForSecondProject.RZ < 10 && ManagerForSecondProject.AMM == 15 && ManagerForSecondProject.MECH < 50) && DIALOG_MANAGER.PJ == 0){
           GO.SetActive(true);
                ManagerForSecondProject.SCORE = 0;
                ManagerForSecondProject.SoundTrack.Stop();
              Time.timeScale = 0;
        }
        HP_BAR.value = Health;
        if(Health < 0){
            switch(gameObject.tag){
                case "MB":
                GO.SetActive(true);
                ManagerForSecondProject.SCORE = 0;
                ManagerForSecondProject.SoundTrack.Stop();
              Time.timeScale = 0;
                break;
              
            case "enemy":
            if(gameObject.name == "GER_NORMALSOL"){
               
                ManagerForSecondProject.RZ += 5;
                ManagerForSecondProject.AMM += 5;
            }
                ManagerForSecondProject.Enemy_Defeated++;
                Destroy(transform.parent.gameObject);
            break;
            case "Player":
            ManagerForSecondProject.SCORE -= 10;
            ManagerForSecondProject.Player_Defeated++;
            Destroy(transform.gameObject);
            break;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col){
        if(gameObject.name == "MB" && col.transform.tag == "enemy"){
          BaseDefender.EnemySpotted = true;
        }
          
    }
    void OnTriggerExit2D(Collider2D col1){
        if(gameObject.name == "MB" && col1.transform.tag == "enemy"){
         BaseDefender.EnemySpotted = false;
        }
    }
}
