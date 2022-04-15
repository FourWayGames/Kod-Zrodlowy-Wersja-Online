using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BUTTON_STORAGE : MonoBehaviour
{
    public GameObject DZW, GRAJ, AUTO, MainMenu, HST, SidePanelPH, SidePanelWP, SidePanelWM, DefaultInfHis, ACT, MDT, HHT, HLRT, SplashScreen, OAT, OGT, BGWT, HVT, GPT, PPT, WPWT, PKT, BPT, ObGT, PWT;
    public AudioSource D, sdt;
    public static bool PopupShowed, UnlockAC, UnlockMD, UnlockHH, UnlockHLR, UnlockOA, UnlockOG, UnlockBGW, UnlockHV, UnlockGP, UnlockPP, UnlockWPW, UnlockPK, UnlockBP, UnlockObG, UnlockPW;
    private bool SwitchTab;
    public string PressedButton;
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
        HV.onClick.AddListener(hvt);
        GP.onClick.AddListener(gp);
        PP.onClick.AddListener(pp);
        WPW.onClick.AddListener(wpwt);
        PK.onClick.AddListener(pkt);
        BP.onClick.AddListener(bp);
        ObG.onClick.AddListener(obg);
        PW.onClick.AddListener(pw);
    }

    void Update()
    {
        if(SplashScreen == null && !sdt.isPlaying){
            sdt.Play();
        }
        if(Input.GetKeyDown(KeyCode.Escape)){
          
            GRAJ.SetActive(false);
            DZW.SetActive(false);
            AUTO.SetActive(false);
            HST.SetActive(false);
        }
          if(GRAJ.activeSelf || DZW.activeSelf || AUTO.activeSelf || HST.activeSelf){
              MainMenu.SetActive(false);
          }else{
              MainMenu.SetActive(true);
          }

          switch(PressedButton){
              case null:
               SidePanelPH.SetActive(false);
               SidePanelWM.SetActive(false);
               SidePanelWP.SetActive(false);
               DefaultInfHis.SetActive(true);     
              break;
               case "PosHis":
               SidePanelPH.SetActive(true);
               SidePanelWM.SetActive(false);
               SidePanelWP.SetActive(false);
               DefaultInfHis.SetActive(false);       
               break;
               case "WazPoj":
               SidePanelWP.SetActive(true);
               SidePanelWM.SetActive(false);
               SidePanelPH.SetActive(false); 
               DefaultInfHis.SetActive(false);        
               break;
               case "WazMiej":
               SidePanelWM.SetActive(true);
               SidePanelPH.SetActive(false);
               SidePanelWP.SetActive(false);    
               DefaultInfHis.SetActive(false);     
               break;

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
        if(PressedButton != "PosHis"){
            PressedButton = "PosHis";
        }else{
            PressedButton = null;
        }
        
            

    }
    void WP(){
        D.Play();
        if(PressedButton != "WazPoj"){
            PressedButton = "WazPoj";
        }else{
            PressedButton = null;
        }
        
        
    }
    void WM(){
        D.Play();
        if(PressedButton != "WazMiej"){
            PressedButton = "WazMiej";
        }else{
            PressedButton = null;
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
    void hvt(){
         D.Play();
          if(ObGT.activeSelf){
             ObGT.SetActive(false);
         }
         if(GPT.activeSelf){
             GPT.SetActive(false);
         }
         if(WPWT.activeSelf){
             WPWT.SetActive(false);
         }
         if(PWT.activeSelf){
             PWT.SetActive(false);
         }
         if(BPT.activeSelf){
             BPT.SetActive(false);
         }
         if(PKT.activeSelf){
             PKT.SetActive(false);
         }
         if(PPT.activeSelf){
             PPT.SetActive(false);
         }
         if(!HVT.activeSelf){
             HVT.SetActive(true);
         }else{
             HVT.SetActive(false);
         }
    }
    void gp(){
         D.Play();
          if(ObGT.activeSelf){
             ObGT.SetActive(false);
         }
         if(HVT.activeSelf){
             HVT.SetActive(false);
         }
         if(WPWT.activeSelf){
             WPWT.SetActive(false);
         }
         if(PWT.activeSelf){
             PWT.SetActive(false);
         }
         if(BPT.activeSelf){
             BPT.SetActive(false);
         }
         if(PKT.activeSelf){
             PKT.SetActive(false);
         }
         if(PPT.activeSelf){
             PPT.SetActive(false);
         }
         if(!GPT.activeSelf){
             GPT.SetActive(true);
         }else{
             GPT.SetActive(false);
         }
    }
    void pp(){
        D.Play();
         if(ObGT.activeSelf){
             ObGT.SetActive(false);
         }
         if(GPT.activeSelf){
             GPT.SetActive(false);
         }
         if(WPWT.activeSelf){
             WPWT.SetActive(false);
         }
         if(PWT.activeSelf){
             PWT.SetActive(false);
         }
         if(BPT.activeSelf){
             BPT.SetActive(false);
         }
         if(PKT.activeSelf){
             PKT.SetActive(false);
         }
         if(HVT.activeSelf){
             HVT.SetActive(false);
         }
         if(!PPT.activeSelf){
             PPT.SetActive(true);
         }else{
             PPT.SetActive(false);
         }
    }
    void wpwt(){
        D.Play();
         if(ObGT.activeSelf){
             ObGT.SetActive(false);
         }
         if(GPT.activeSelf){
             GPT.SetActive(false);
         }
         if(HVT.activeSelf){
             HVT.SetActive(false);
         }
         if(PWT.activeSelf){
             PWT.SetActive(false);
         }
         if(BPT.activeSelf){
             BPT.SetActive(false);
         }
         if(PKT.activeSelf){
             PKT.SetActive(false);
         }
         if(PPT.activeSelf){
             PPT.SetActive(false);
         }
         if(!WPWT.activeSelf){
             WPWT.SetActive(true);
         }else{
             WPWT.SetActive(false);
         }
    }
    void pkt(){
        D.Play();
         if(ObGT.activeSelf){
             ObGT.SetActive(false);
         }
         if(GPT.activeSelf){
             GPT.SetActive(false);
         }
         if(WPWT.activeSelf){
             WPWT.SetActive(false);
         }
         if(PWT.activeSelf){
             PWT.SetActive(false);
         }
         if(BPT.activeSelf){
             BPT.SetActive(false);
         }
         if(HVT.activeSelf){
             HVT.SetActive(false);
         }
         if(PPT.activeSelf){
             PPT.SetActive(false);
         }
         if(!PKT.activeSelf){
             PKT.SetActive(true);
         }else{
             PKT.SetActive(false);
         }
    }
    void bp(){
        D.Play();
         if(ObGT.activeSelf){
             ObGT.SetActive(false);
         }
         if(GPT.activeSelf){
             GPT.SetActive(false);
         }
         if(WPWT.activeSelf){
             WPWT.SetActive(false);
         }
         if(PWT.activeSelf){
             PWT.SetActive(false);
         }
         if(HVT.activeSelf){
             HVT.SetActive(false);
         }
         if(PKT.activeSelf){
             PKT.SetActive(false);
         }
         if(PPT.activeSelf){
             PPT.SetActive(false);
         }
         if(!BPT.activeSelf){
             BPT.SetActive(true);
         }else{
             BPT.SetActive(false);
         }
    }
    void obg(){
        D.Play();
         if(HVT.activeSelf){
             HVT.SetActive(false);
         }
         if(GPT.activeSelf){
             GPT.SetActive(false);
         }
         if(WPWT.activeSelf){
             WPWT.SetActive(false);
         }
         if(PWT.activeSelf){
             PWT.SetActive(false);
         }
         if(BPT.activeSelf){
             BPT.SetActive(false);
         }
         if(PKT.activeSelf){
             PKT.SetActive(false);
         }
         if(PPT.activeSelf){
             PPT.SetActive(false);
         }
         if(!ObGT.activeSelf){
             ObGT.SetActive(true);
         }else{
             ObGT.SetActive(false);
         }
    }
    void pw(){
       D.Play();
        if(ObGT.activeSelf){
             ObGT.SetActive(false);
         }
         if(GPT.activeSelf){
             GPT.SetActive(false);
         }
         if(WPWT.activeSelf){
             WPWT.SetActive(false);
         }
         if(HVT.activeSelf){
             HVT.SetActive(false);
         }
         if(BPT.activeSelf){
             BPT.SetActive(false);
         }
         if(PKT.activeSelf){
             PKT.SetActive(false);
         }
         if(PPT.activeSelf){
             PPT.SetActive(false);
         }
         if(!PWT.activeSelf){
             PWT.SetActive(true);
         }else{
             PWT.SetActive(false);
         }
    }
}
