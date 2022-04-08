using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

    
    public class FPS : MonoBehaviour
    {
    
        public Text fpsRect;
        GUIStyle style;
        public static bool fps_allow;
        float fps;
        
     void  Start()
     {
          style = new GUIStyle();
         style.fontSize = 20;
         StartCoroutine(RecalculateFPS());
     }

     void Update(){
           if(fps_allow){
                 fpsRect.enabled = true;
           }if(!fps_allow){
               fpsRect.enabled = false;
           }
     }

     private IEnumerator RecalculateFPS()
     {
         while(true)
         {
             fps=1/Time.deltaTime;
             yield return new WaitForSeconds(1);
         }
     }

     void OnGUI()
     {
         fpsRect.text = ("FPS: " + (int)fps);

     }



}