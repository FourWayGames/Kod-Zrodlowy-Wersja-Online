using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiPlacer : MonoBehaviour
{
    //Prosty skrypt blokujący stawianie jednostek na budynkach
    void OnMouseOver(){
        
        ManagerForSecondProject.Block = true;
    }
    void OnMouseExit(){
        ManagerForSecondProject.Block = false;
    }
}
