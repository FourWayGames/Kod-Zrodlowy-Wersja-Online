using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class IntroScript : MonoBehaviour
{
    //Właściwie to używamy tego też do outro, ale nazwa niech już zostanie.
     public TMP_Text Informejszyn;
      void Start(){
         Time.timeScale = 1;
      }
    void Update()
    {
         Scene os = SceneManager.GetActiveScene ();
         string ns = os.name;
         
        if(Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Escape)){
            switch(ns){
                case "IntroScene":
                Informejszyn.text = "Przechodze do poziomu...";
                 SceneManager.LoadScene("Tutorial_Level");
                break;
                case "OutroLevel":
                Informejszyn.text = "Przechodze do menu...";
                 SceneManager.LoadScene("MM");
                break;
            }
        
        }
    }

    void TransportToLVL1(){
        SceneManager.LoadScene("Tutorial_Level");
    }

    void TransportToMenu(){
      SceneManager.LoadScene("MM");
    }
}
