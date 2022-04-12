using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShowRating : MonoBehaviour
{
    private Image Rating_Main;
    private Sprite[] Rating_Type;
    void Start()
    {
        Rating_Type = Resources.LoadAll<Sprite>("LMAO");
        Rating_Main = GetComponent<Image>();
    }
             
    
    void Update()
    {
      
         switch(name){
           case "Tutorial_Level":
           
           if((Levels_Manager.LVL0_HighScore <= 200) && (Levels_Manager.LVL0_HighScore >= 180)){ // RANK S
           
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL0_HighScore <= 170) && (Levels_Manager.LVL0_HighScore >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL0_HighScore <= 130) && (Levels_Manager.LVL0_HighScore >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL0_HighScore <= 90) && (Levels_Manager.LVL0_HighScore >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL0_HighScore <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
           case "Level_1":
           if(Levels_Manager.LVL1_HighScore >= 180){ // RANK S
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL1_HighScore <= 170) && (Levels_Manager.LVL1_HighScore >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL1_HighScore <= 130) && (Levels_Manager.LVL1_HighScore >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL1_HighScore <= 90) && (Levels_Manager.LVL1_HighScore >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL1_HighScore <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
           case "Level_2":
            if((Levels_Manager.LVL2_HighScore <= 200) && (Levels_Manager.LVL2_HighScore >= 180)){ // RANK S
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL2_HighScore <= 170) && (Levels_Manager.LVL2_HighScore >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL2_HighScore <= 130) && (Levels_Manager.LVL2_HighScore >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL2_HighScore <= 90) && (Levels_Manager.LVL2_HighScore >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL2_HighScore <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
           case "Level_3":
           if((Levels_Manager.LVL3_HighScore <= 200) && (Levels_Manager.LVL3_HighScore >= 180)){ // RANK S
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL3_HighScore <= 170) && (Levels_Manager.LVL3_HighScore >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL3_HighScore <= 130) && (Levels_Manager.LVL3_HighScore >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL3_HighScore <= 90) && (Levels_Manager.LVL3_HighScore >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL3_HighScore <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
           case "Level_4":
           if((Levels_Manager.LVL4_HighScore <= 200) && (Levels_Manager.LVL4_HighScore >= 180)){ // RANK S
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL4_HighScore <= 170) && (Levels_Manager.LVL4_HighScore >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL4_HighScore <= 130) && (Levels_Manager.LVL4_HighScore >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL4_HighScore <= 90) && (Levels_Manager.LVL4_HighScore >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL4_HighScore <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
           case "Level_5":
            if((Levels_Manager.LVL5_HighScore <= 200) && (Levels_Manager.LVL5_HighScore >= 180)){ // RANK S
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL5_HighScore <= 170) && (Levels_Manager.LVL5_HighScore >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL5_HighScore <= 130) && (Levels_Manager.LVL5_HighScore >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL5_HighScore <= 90) && (Levels_Manager.LVL5_HighScore >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL5_HighScore <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
           case "Level_6":
            if((Levels_Manager.LVL6_HighScore <= 200) && (Levels_Manager.LVL6_HighScore >= 180)){ // RANK S
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL6_HighScore <= 170) && (Levels_Manager.LVL6_HighScore >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL6_HighScore <= 130) && (Levels_Manager.LVL6_HighScore >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL6_HighScore <= 90) && (Levels_Manager.LVL6_HighScore >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL6_HighScore <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
           case "Level_7":
            if((Levels_Manager.LVL7_HighScore <= 200) && (Levels_Manager.LVL7_HighScore >= 180)){ // RANK S
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL7_HighScore <= 170) && (Levels_Manager.LVL7_HighScore >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL7_HighScore <= 130) && (Levels_Manager.LVL7_HighScore >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL7_HighScore <= 90) && (Levels_Manager.LVL7_HighScore >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL7_HighScore <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
           case "Level_8":
           if((Levels_Manager.LVL8_HighScore <= 200) && (Levels_Manager.LVL8_HighScore >= 180)){ // RANK S
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL8_HighScore <= 170) && (Levels_Manager.LVL8_HighScore >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL8_HighScore <= 130) && (Levels_Manager.LVL8_HighScore >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL8_HighScore <= 90) && (Levels_Manager.LVL8_HighScore >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL8_HighScore <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
         }

        
    }
}
