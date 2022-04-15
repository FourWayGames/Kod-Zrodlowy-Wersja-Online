using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    public Animator ANIM;
    public static bool ShopAble;
    public Button Pistol, Sztorm, Snajper, Mina, Czolg;
    public GameObject Bonus_grid;                                                           //////Te CanBuy'e są po to żeby gra sprawdzała czy możesz coś kupić, jak nie to przegrywasz
    public static bool NormalSoldier, SztormSoldier, SnajperSoldier, MinaEntity, CzolgEntity, CanBuyPistol, CanBuySztorm, CanBuySniper, CanBuyMina, CanbuyCzolg;
    void Start()
    {
        Button btn = Pistol.GetComponent<Button>();
        btn.onClick.AddListener(BUY_Pistol);

        if(Sztorm != null){
            Button btn1 = Sztorm.GetComponent<Button>();
        btn1.onClick.AddListener(BUY_Sztorm);
        }
         if(Snajper != null){
             Button btn2 = Snajper.GetComponent<Button>();
          btn2.onClick.AddListener(BUY_Snajper);
        }
         if(Mina != null){
             Button btn3 = Mina.GetComponent<Button>();
         btn3.onClick.AddListener(BUY_Mina);
        }
         if(Czolg != null){
             Button btn4 = Czolg.GetComponent<Button>();
          btn4.onClick.AddListener(BUY_Czolg);
        }
    }

    
    void Update()
    {

        if(ManagerForSecondProject.RZ < 15 && ManagerForSecondProject.AMM < 15){
            CanBuyPistol = false;
        }else{
            CanBuyPistol = true;
        }
        if(ManagerForSecondProject.RZ < 30 && ManagerForSecondProject.AMM < 30){
            CanBuySztorm = false;
        }else{
            CanBuySztorm = true;
        }
        if(ManagerForSecondProject.RZ < 10 && ManagerForSecondProject.AMM < 40){
            CanBuySniper = false;
        }else{
            CanBuySniper = true;
        }if(ManagerForSecondProject.MECH < 50){
            CanBuyMina = false;
        }else{
            CanBuyMina = true;
        }if(ManagerForSecondProject.MECH < 75 && ManagerForSecondProject.AMM < 30){
         CanbuyCzolg = false;
        }else{
            CanbuyCzolg = true;
        }
        if(!ManagerForSecondProject.INTRO){
 if(Input.GetKeyDown("e") && ShopAble == false){
            ANIM.SetBool("ShoppingTime", true);
           Bonus_grid.SetActive(true);
            ShopAble = true;
        } else if(Input.GetKeyDown("e") &&  ShopAble == true){
            SztormSoldier = false;
        SnajperSoldier = false;
        MinaEntity = false;
        CzolgEntity = false;
        NormalSoldier = false;
            ANIM.SetBool("ShoppingTime", false);
            Bonus_grid.SetActive(false);
           ShopAble = false;
           
        }
        }
       

       
    }

    void BUY_Pistol(){
        SztormSoldier = false;
        SnajperSoldier = false;
        MinaEntity = false;
        CzolgEntity = false;
        NormalSoldier = true;
    }
    void BUY_Sztorm(){
        SnajperSoldier = false;
        MinaEntity = false;
        CzolgEntity = false;
        NormalSoldier = false;
        SztormSoldier = true;
    }
    void BUY_Snajper(){
        MinaEntity = false;
        CzolgEntity = false;
        NormalSoldier = false;
        SztormSoldier = false;
        SnajperSoldier = true;
    }
    void BUY_Mina(){
        SztormSoldier = false;
        SnajperSoldier = false;
        CzolgEntity = false;
        NormalSoldier = false;
        MinaEntity = true;
    }
    void BUY_Czolg(){
        SztormSoldier = false;
        SnajperSoldier = false;
        MinaEntity = false;
        NormalSoldier = false;
        CzolgEntity = true;
    }

   
}
