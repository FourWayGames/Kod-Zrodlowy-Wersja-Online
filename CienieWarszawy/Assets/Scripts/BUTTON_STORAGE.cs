using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BUTTON_STORAGE : MonoBehaviour
{
    public GameObject DZW, GRAJ, AUTO, MainMenu, HST, SidePanelPH, SidePanelWP, SidePanelWM, DefaultInfHis, ACT, MDT, HHT, HLRT, SplashScreen, OAT, OGT, BGWT;
    public AudioSource D, sdt;
    public static bool PopupShowed;
    public Button DzwB, GrajB, AutoB, Dzw2B, Graj2B, Auto2B, HisB, His2B, PosH, WaPoj, WaMi, AC, MD, HH, HLR, OA, OG, BGW, HV, GP, PP, WPW, PK, BP, ObG, PW;
    void Start()
    {
        if(!PopupShowed){
          SplashScreen.SetActive(true);
        }
        
        DzwB.onClick.AddListener(dzwk);
        HisB.onClick.AddListener(hst);
        His2B.onClick.AddListener(hst);
        GrajB.onClick.AddListener(grj);
        AutoB.onClick.AddListener(at);
        Dzw2B.onClick.AddListener(dzwk);
        Graj2B.onClick.AddListener(grj);
        Auto2B.onClick.AddListener(at);
        PosH.onClick.AddListener(PH);
        WaPoj.onClick.AddListener(WP);
        WaMi.onClick.AddListener(WM);
        AC.onClick.AddListener(ac);
        MD.onClick.AddListener(md);
        HH.onClick.AddListener(hh);
        HLR.onClick.AddListener(hlr);
        OA.onClick.AddListener(oa);
        OG.onClick.AddListener(og);
        BGW.onClick.AddListener(bgw);
    }

    void Update()
    {
        if(SplashScreen == null && !sdt.isPlaying){
            sdt.Play();
        }
          if( GRAJ.activeSelf || DZW.activeSelf || AUTO.activeSelf || HST.activeSelf ){
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
            if(HST.activeSelf){
               HST.SetActive(false);
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
            if(HST.activeSelf){
               HST.SetActive(false);
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
           if(HST.activeSelf){
               HST.SetActive(false);
           }
        } else{
            AUTO.SetActive(false);
        }

    }
    void hst(){
            D.Play();
        if(!HST.activeSelf){
           HST.SetActive(true);
           if(GRAJ.activeSelf){
               GRAJ.SetActive(false);
           }
           if(DZW.activeSelf){
               DZW.SetActive(false);
           }
        } else{
            HST.SetActive(false);
        }
    }
    void PH(){
        D.Play();
        if(SidePanelWP.activeSelf){
               SidePanelWP.SetActive(false);
           }
           if(SidePanelWM.activeSelf){
               SidePanelWM.SetActive(false);
           }
           
        if(DefaultInfHis.activeSelf){
            SidePanelPH.SetActive(true);
            DefaultInfHis.SetActive(false);
        }else{
            SidePanelPH.SetActive(false);
           DefaultInfHis.SetActive(true); 
        }
    }
    void WP(){
        D.Play();
         if(SidePanelPH.activeSelf){
               SidePanelPH.SetActive(false);
           }
           if(SidePanelWM.activeSelf){
               SidePanelWM.SetActive(false);
           }
        if(DefaultInfHis.activeSelf){
            SidePanelWP.SetActive(true);
            DefaultInfHis.SetActive(false);
        }else{
            SidePanelWP.SetActive(false);
           DefaultInfHis.SetActive(true); 
        }
    }
    void WM(){
         if(SidePanelPH.activeSelf){
               SidePanelPH.SetActive(false);
           }
           if(SidePanelWP.activeSelf){
               SidePanelWP.SetActive(false);
           }
        D.Play();
        if(DefaultInfHis.activeSelf){
            SidePanelWM.SetActive(true);
            DefaultInfHis.SetActive(false);
        }else{
            SidePanelWM.SetActive(false);
           DefaultInfHis.SetActive(true); 
        }
    }
    void ac(){
         D.Play();

         if(MDT.activeSelf){
             MDT.SetActive(false);
         }
         if(HHT.activeSelf){
             HHT.SetActive(false);
         }
         if(HLRT.activeSelf){
             HLRT.SetActive(false);
         }
         if(!ACT.activeSelf){
             ACT.SetActive(true);
         }else{
             ACT.SetActive(false);
         }
    }
    void md(){
      D.Play();

      if(ACT.activeSelf){
             ACT.SetActive(false);
         }
         if(HHT.activeSelf){
             HHT.SetActive(false);
         }
         if(HLRT.activeSelf){
             HLRT.SetActive(false);
         }
         if(!MDT.activeSelf){
             MDT.SetActive(true);
         }else{
             MDT.SetActive(false);
         }
    }
    void hh(){
       D.Play();
       if(ACT.activeSelf){
             ACT.SetActive(false);
         }
         if(MDT.activeSelf){
             MDT.SetActive(false);
         }
         if(HLRT.activeSelf){
             HLRT.SetActive(false);
         }
         if(!HHT.activeSelf){
             HHT.SetActive(true);
         }else{
             HHT.SetActive(false);
         }
    }
    void hlr(){
        D.Play();
        if(ACT.activeSelf){
             ACT.SetActive(false);
         }
         if(HHT.activeSelf){
             HHT.SetActive(false);
         }
         if(MDT.activeSelf){
             MDT.SetActive(false);
         }
         if(!HLRT.activeSelf){
             HLRT.SetActive(true);
         }else{
             HLRT.SetActive(false);
         }
    }
    void oa(){
         D.Play();
         if(OGT.activeSelf){
             OGT.SetActive(false);
         }
         if(BGWT.activeSelf){
             BGWT.SetActive(false);
         }
         if(!OAT.activeSelf){
             OAT.SetActive(true);
         }else{
             OAT.SetActive(false);
         }
    }
    void og(){
         D.Play();
           if(OAT.activeSelf){
             OAT.SetActive(false);
         }
         if(BGWT.activeSelf){
             BGWT.SetActive(false);
         }
         if(!OGT.activeSelf){
             OGT.SetActive(true);
         }else{
             OGT.SetActive(false);
         }
    }
    void bgw(){
        D.Play();
          if(OGT.activeSelf){
             OGT.SetActive(false);
         }
         if(OAT.activeSelf){
             OAT.SetActive(false);
         }
         if(!BGWT.activeSelf){
             BGWT.SetActive(true);
         }else{
             BGWT.SetActive(false);
         }
        
    }
}
