using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class notifikacja : MonoBehaviour
{
    //Ostrzeżenie odpalane gdy FPS'y w wersji Online są poniżej 30
    public static bool accepted;
    public GameObject Notification;
    public Button btn;
    public AudioSource push;
    void Start()
    {
        btn.onClick.AddListener(Accepte);
    }

    
    void Update()
    {
        if(accepted){
            Notification.SetActive(false);
        }
    }

    void Accepte(){
        push.Play();
        accepted = true;
    }
}
