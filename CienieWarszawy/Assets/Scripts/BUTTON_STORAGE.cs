using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BUTTON_STORAGE : MonoBehaviour
{
    public GameObject DZW, GRAJ, AUTO, MainMenu;
    public AudioSource D;
    public Button DzwB, GrajB, AutoB;
    void Start()
    {
        DzwB.onClick.AddListener(dzwk);
        GrajB.onClick.AddListener(grj);
        AutoB.onClick.AddListener(at);
    }

    void Update()
    {
        
          if( GRAJ.activeSelf || DZW.activeSelf || AUTO.activeSelf ){
              MainMenu.SetActive(false);
          }else{
              MainMenu.SetActive(true);
          }
        
    }

    void dzwk(){
        D.Play();
         if(!DZW.activeSelf){
            DZW.SetActive(true);
            if(GRAJ.activeSelf){
                GRAJ.SetActive(false);
            }
            if(AUTO.activeSelf){
                AUTO.SetActive(false);
            }
        } else{
            DZW.SetActive(false);
        }

    }
    void grj(){
                D.Play();
        if(!GRAJ.activeSelf){
            GRAJ.SetActive(true);
            if(DZW.activeSelf){
                DZW.SetActive(false);
            }
            if(AUTO.activeSelf){
                AUTO.SetActive(false);
            }
        } else{
            GRAJ.SetActive(false);
        }

    }
    void at(){
                D.Play();
        if(!AUTO.activeSelf){
           AUTO.SetActive(true);
           if(GRAJ.activeSelf){
               GRAJ.SetActive(false);
           }
           if(DZW.activeSelf){
               DZW.SetActive(false);
           }
        } else{
            AUTO.SetActive(false);
        }

    }
}
