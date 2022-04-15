using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Wyjdzzgry : MonoBehaviour
{
    public Button wyjdz;
    // Start is called before the first frame update
    void Start()
    {
        wyjdz.onClick.AddListener(wyjdzstad);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void wyjdzstad(){
         Application.Quit();
    }
}
