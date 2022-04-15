using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class opt : MonoBehaviour
{
    public Text TXT;
    public Slider _Slider;
    public Image IMG;
   // public AudioSource AS;
    public Sprite[] IMG_Ad;
    public static float GlobalSoundNumber = 100;
     void Start(){
		//_Slider.onValueChanged.AddListener(delegate{Sound();});
     
             _Slider.value = GlobalSoundNumber;

     
      
     }

     void Update(){
       
        //if(Input.GetKey("z")){
       //    PlayerPrefs.DeleteAll();
       // }
       
        var procent = _Slider.value / 1 * 100;
        TXT.text =  (int)procent + "%";
        AudioListener.volume = _Slider.value;
        GlobalSoundNumber = _Slider.value;

         
        if(_Slider.value > 0.51f){
            IMG.sprite = IMG_Ad[2];
        } 
        else if(_Slider.value < 0.50f && _Slider.value != 0){
           
           IMG.sprite = IMG_Ad[1];
        }
        else if(_Slider.value < 0.1f){
           
           IMG.sprite = IMG_Ad[0];
        }
     }

     //void Sound(){
      //  AS.Play();
    // }
}
