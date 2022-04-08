using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    public Animator ANIM;
    public static bool ShopAble;
    public Button NF;
    public GameObject Bonus_grid;
    public static bool NormalSoldier;
    void Start()
    {
        Button btn = NF.GetComponent<Button>();
        btn.onClick.AddListener(BUY);
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

    void BUY(){
        NormalSoldier = true;
    }

   
}
