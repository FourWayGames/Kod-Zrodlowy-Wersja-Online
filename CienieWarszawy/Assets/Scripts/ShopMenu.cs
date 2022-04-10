using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    public Animator ANIM;
    public static bool ShopAble;
    public Button Pistol, Sztorm, Snajper, Mina, Czolg;
    public GameObject Bonus_grid;
    public static bool NormalSoldier, SztormSoldier, SnajperSoldier, MinaEntity, CzolgEntity;
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
        if(!ManagerForSecondProject.INTRO){
 if(Input.GetKeyDown("e") && ShopAble == false){
            ANIM.SetBool("ShoppingTime", true);
           Bonus_grid.SetActive(true);
            ShopAble = true;
        } else if(Input.GetKeyDown("e") &&  ShopAble == true){
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
