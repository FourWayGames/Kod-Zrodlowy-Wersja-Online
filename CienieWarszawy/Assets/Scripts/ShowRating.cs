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
        Rating_Type = Resources.LoadAll<Sprite>("LMAO"); //Bo jak zrobie to poza void'ami to mi wywala błąd że nie można, ehh, trzeba załadować na starcie, czy to zła implementacja, najprawdopodobniej...
        Rating_Main = GetComponent<Image>();
    }

    
    void Update()
    {
      
         switch(name){
           case "Tutorial_Level":
           
           if((Levels_Manager.LVL0_Score <= 200) && (Levels_Manager.LVL0_Score >= 180)){ // RANK S
           
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL0_Score <= 170) && (Levels_Manager.LVL0_Score >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL0_Score <= 130) && (Levels_Manager.LVL0_Score >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL0_Score <= 90) && (Levels_Manager.LVL0_Score >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL0_Score <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
           case "Level_1":
           if(Levels_Manager.LVL1_Score >= 180){ // RANK S
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL1_Score <= 170) && (Levels_Manager.LVL1_Score >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL1_Score <= 130) && (Levels_Manager.LVL1_Score >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL1_Score <= 90) && (Levels_Manager.LVL1_Score >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL1_Score <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
           case "Level_2":
            if((Levels_Manager.LVL2_Score <= 200) && (Levels_Manager.LVL2_Score >= 180)){ // RANK S
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL2_Score <= 170) && (Levels_Manager.LVL2_Score >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL2_Score <= 130) && (Levels_Manager.LVL2_Score >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL2_Score <= 90) && (Levels_Manager.LVL2_Score >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL2_Score <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
           case "Level_3":
           if((Levels_Manager.LVL3_Score <= 200) && (Levels_Manager.LVL3_Score >= 180)){ // RANK S
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL3_Score <= 170) && (Levels_Manager.LVL3_Score >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL3_Score <= 130) && (Levels_Manager.LVL3_Score >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL3_Score <= 90) && (Levels_Manager.LVL3_Score >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL3_Score <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
           case "Level_4":
           if((Levels_Manager.LVL4_Score <= 200) && (Levels_Manager.LVL4_Score >= 180)){ // RANK S
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL4_Score <= 170) && (Levels_Manager.LVL4_Score >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL4_Score <= 130) && (Levels_Manager.LVL4_Score >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL4_Score <= 90) && (Levels_Manager.LVL4_Score >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL4_Score <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
           case "Level_5":
            if((Levels_Manager.LVL5_Score <= 200) && (Levels_Manager.LVL5_Score >= 180)){ // RANK S
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL5_Score <= 170) && (Levels_Manager.LVL5_Score >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL5_Score <= 130) && (Levels_Manager.LVL5_Score >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL5_Score <= 90) && (Levels_Manager.LVL5_Score >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL5_Score <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
           case "Level_6":
            if((Levels_Manager.LVL6_Score <= 200) && (Levels_Manager.LVL6_Score >= 180)){ // RANK S
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL6_Score <= 170) && (Levels_Manager.LVL6_Score >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL6_Score <= 130) && (Levels_Manager.LVL6_Score >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL6_Score <= 90) && (Levels_Manager.LVL6_Score >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL6_Score <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
           case "Level_7":
            if((Levels_Manager.LVL7_Score <= 200) && (Levels_Manager.LVL7_Score >= 180)){ // RANK S
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL7_Score <= 170) && (Levels_Manager.LVL7_Score >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL7_Score <= 130) && (Levels_Manager.LVL7_Score >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL7_Score <= 90) && (Levels_Manager.LVL7_Score >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL7_Score <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
           case "Level_8":
           if((Levels_Manager.LVL8_Score <= 200) && (Levels_Manager.LVL8_Score >= 180)){ // RANK S
              Rating_Main.sprite = Rating_Type[4];
           }if((Levels_Manager.LVL8_Score <= 170) && (Levels_Manager.LVL8_Score >= 140)){ // RANK A
              Rating_Main.sprite = Rating_Type[0];
           }if((Levels_Manager.LVL8_Score <= 130) && (Levels_Manager.LVL8_Score >= 100)){ // RANK B
              Rating_Main.sprite = Rating_Type[1];
           }
           if((Levels_Manager.LVL8_Score <= 90) && (Levels_Manager.LVL8_Score >= 50)){ // RANK C
              Rating_Main.sprite = Rating_Type[2];
           } if(Levels_Manager.LVL8_Score <= 40){ // RANK D
              Rating_Main.sprite = Rating_Type[3];
           }
           break;
         }

        
    }
}
