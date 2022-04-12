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
    public Toggle ShowFPS;
    public static float GlobalSoundNumber = 100;
     void Start(){
		//_Slider.onValueChanged.AddListener(delegate{Sound();});
      if(PlayerPrefs.HasKey("SoundNumber")){
        _Slider.value = PlayerPrefs.GetFloat("SoundNumber");
      }else{
         FPS.fps_allow = false;
       _Slider.value = 100;
      }
     
       switch(FPS.fps_allow){
          case true:
          PlayerPrefs.SetInt("FPS", 1);
          break;
          case false:
           PlayerPrefs.SetInt("FPS", 0);
          break;
       }
     }

     void Update(){
        //if(Input.GetKey("z")){
       //    PlayerPrefs.DeleteAll();
       // }
        if(PlayerPrefs.GetInt("FPS") == 1){
           FPS.fps_allow = true;
        }
        if(PlayerPrefs.GetInt("FPS") == 0){
           FPS.fps_allow = false;
        }
        var procent = _Slider.value / 1 * 100;
        TXT.text =  (int)procent + "%";
        AudioListener.volume = _Slider.value;
        PlayerPrefs.SetFloat("SoundNumber", _Slider.value);
         
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
