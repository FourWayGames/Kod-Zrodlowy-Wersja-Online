using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Levels_Manager : MonoBehaviour
{
    public Button[] Wybierz_Level;
    public Button Zacznij_Gre;
    public Text Nazwa_Poziomu, Opis_Poziomu, Lokacja_i_Czas_Poziomu, przerywacz;
    public AudioSource click;
    public Sprite Selected, Deselected;
    public GameObject SplashScreen;
    private string Level_To_Play;
    public static bool LVL0_ShowScore,LVL1, LVL1_ShowScore, LVL2, LVL2_ShowScore, LVL3, LVL3_ShowScore, LVL4, LVL4_ShowScore, LVL5, LVL5_ShowScore, LVL6,  LVL6_ShowScore, LVL7, LVL7_ShowScore, LVL8, LVL8_ShowScore;
    public static int LVL0_Score, LVL0_HighScore, LVL1_Score, LVL1_HighScore, LVL2_Score, LVL2_HighScore, LVL3_Score, LVL3_HighScore, LVL4_Score, LVL4_HighScore, LVL5_Score, LVL5_HighScore, LVL6_Score, LVL6_HighScore, LVL7_Score, LVL7_HighScore, LVL8_Score, LVL8_HighScore;
    
    void Start()
    {
        Nazwa_Poziomu.enabled = false;
        Opis_Poziomu.enabled = false;     
        Lokacja_i_Czas_Poziomu.enabled = false;
        przerywacz.enabled = false;
        Wybierz_Level[0].onClick.AddListener(LvL0);
        Wybierz_Level[1].onClick.AddListener(LvL1);
        Wybierz_Level[2].onClick.AddListener(LvL2);
        Wybierz_Level[3].onClick.AddListener(LvL3);
        Wybierz_Level[4].onClick.AddListener(LvL4);
        Wybierz_Level[5].onClick.AddListener(LvL5);
        Wybierz_Level[6].onClick.AddListener(LvL6);
        Wybierz_Level[7].onClick.AddListener(LvL7);
        Wybierz_Level[8].onClick.AddListener(LvL8);     
        Zacznij_Gre.onClick.AddListener(PlayIt);
		
        
    }

    
    void Update()
    {
        if(LVL0_Score >= LVL0_HighScore){
            LVL0_HighScore = LVL0_Score;
        }
        if(LVL1_Score >= LVL1_HighScore){
            LVL1_HighScore = LVL1_Score;
        }
        if(LVL2_Score >= LVL2_HighScore){
            LVL2_HighScore = LVL2_Score;
        }
        if(LVL3_Score >= LVL3_HighScore){
            LVL3_HighScore = LVL3_Score;
        }
        if(LVL4_Score >= LVL4_HighScore){
            LVL4_HighScore = LVL4_Score;
        }
        if(LVL5_Score >= LVL5_HighScore){
            LVL5_HighScore = LVL5_Score;
        }
        if(LVL6_Score >= LVL6_HighScore){
            LVL6_HighScore = LVL6_Score;
        }
        if(LVL7_Score >= LVL7_HighScore){
            LVL7_HighScore = LVL7_Score;
        }
        if(LVL8_Score >= LVL8_HighScore){
            LVL8_HighScore = LVL8_Score;
        }
        //DEVELOPER STUFF - do wykomentowania na release
        if(Input.GetKeyDown("1")){
            
            PlayerPrefs.SetInt("lvl1", 1);
        }
        if(Input.GetKeyDown("2")){
            PlayerPrefs.SetInt("lvl2", 1);
        }
        if(Input.GetKeyDown("3")){
            PlayerPrefs.SetInt("lvl3", 1);
        }
        if(Input.GetKeyDown("4")){
            PlayerPrefs.SetInt("lvl4", 1);
        }
         if(Input.GetKeyDown("5")){
            PlayerPrefs.SetInt("lvl5", 1);
        }
         if(Input.GetKeyDown("6")){
           PlayerPrefs.SetInt("lvl6", 1);
        }if(Input.GetKeyDown("7")){
            PlayerPrefs.SetInt("lvl7", 1);
        }if(Input.GetKeyDown("8")){
            PlayerPrefs.SetInt("lvl8", 1);
        }if(Input.GetKeyDown("z")){
            PlayerPrefs.DeleteAll();
        }
        
    
        if(PlayerPrefs.GetInt("lvl1") == 1){
            
            Wybierz_Level[1].transform.GetChild(2).gameObject.SetActive(false);
            Wybierz_Level[1].interactable = true;
        }
        if(PlayerPrefs.GetInt("lvl2") == 1){
            Wybierz_Level[2].transform.GetChild(2).gameObject.SetActive(false);
            Wybierz_Level[2].interactable = true;
        }
         if(PlayerPrefs.GetInt("lvl3") == 1){
            Wybierz_Level[3].transform.GetChild(2).gameObject.SetActive(false);
            Wybierz_Level[3].interactable = true;
        }
         if(PlayerPrefs.GetInt("lvl4") == 1){
            Wybierz_Level[4].transform.GetChild(2).gameObject.SetActive(false);
            Wybierz_Level[4].interactable = true;
        }
         if(PlayerPrefs.GetInt("lvl5") == 1){
            Wybierz_Level[5].transform.GetChild(2).gameObject.SetActive(false);
            Wybierz_Level[5].interactable = true;
        }
         if(PlayerPrefs.GetInt("lvl6") == 1){
            Wybierz_Level[6].transform.GetChild(2).gameObject.SetActive(false);
            Wybierz_Level[6].interactable = true;
        }
         if(PlayerPrefs.GetInt("lvl7") == 1){
            Wybierz_Level[7].transform.GetChild(2).gameObject.SetActive(false);
            Wybierz_Level[7].interactable = true;
        }if(PlayerPrefs.GetInt("lvl8") == 1){
            Wybierz_Level[8].transform.GetChild(2).gameObject.SetActive(false);
            Wybierz_Level[8].interactable = true;
        }
        if(Level_To_Play == null){
             Zacznij_Gre.interactable = false;
             Zacznij_Gre.transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ POZIOM";
        } else{
  Zacznij_Gre.interactable = true;
                          Zacznij_Gre.transform.GetChild(0).GetComponent<Text>().text = "ZACZNIJ GRE";
        }

        if(PlayerPrefs.GetInt("lvl0_scr") == 1){
          Wybierz_Level[0].transform.parent.GetChild(1).gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt("lvl1") == 1){
            Wybierz_Level[1].transform.parent.GetChild(2).gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt("lvl2") == 1){
            Wybierz_Level[2].transform.parent.GetChild(2).gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt("lvl3") == 1){
            Wybierz_Level[3].transform.parent.GetChild(2).gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt("lvl4") == 1){
            Wybierz_Level[4].transform.parent.GetChild(2).gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt("lvl5") == 1){
            Wybierz_Level[5].transform.parent.GetChild(2).gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt("lvl6") == 1){
            Wybierz_Level[6].transform.parent.GetChild(2).gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt("lvl7") == 1){
            Wybierz_Level[7].transform.parent.GetChild(2).gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt("lvl8") == 1){
            Wybierz_Level[8].transform.parent.GetChild(2).gameObject.SetActive(true);
        }
    }

    void PlayIt(){
        if(Level_To_Play != null){
           
          SceneManager.LoadScene(Level_To_Play);
        } 
                     
    }

    void LvL0(){
        click.Play();
        for(int i = 0; i < 8; i++){
          if(i == 0) continue;
           Wybierz_Level[i].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
           Wybierz_Level[i].GetComponent<Image>().sprite = Deselected;
        }
        if(Nazwa_Poziomu.enabled == false || Opis_Poziomu.enabled == false || Lokacja_i_Czas_Poziomu.enabled == false || przerywacz.enabled == false){
            Wybierz_Level[0].GetComponent<Image>().sprite = Selected;
            Nazwa_Poziomu.enabled = true;
            przerywacz.enabled = true;
            Opis_Poziomu.enabled = true;
            Lokacja_i_Czas_Poziomu.enabled = true;
            Nazwa_Poziomu.text = "Tutorial - Operacja Victoria";
        Lokacja_i_Czas_Poziomu.text = "Lokacja: Hotel Victoria, Warszawa 1944";
        Opis_Poziomu.text = "Nazywasz się Kamil, od pewnego czasu krążyły plotki jakoby Niemcy mieli najechać na Hotel Victorie, a los chciał, że akurat znalazłeś się w środku wydarzeń jako dowódca, musisz odepchnąć Niemców za wszelką cene!";
        Level_To_Play = "Tutorial_Level";
        Wybierz_Level[0].transform.GetChild(0).GetComponent<Text>().text = "ODZNACZ";
        } else{
            Wybierz_Level[0].GetComponent<Image>().sprite = Deselected;
             Nazwa_Poziomu.enabled = false;
            przerywacz.enabled = false;
            Opis_Poziomu.enabled = false;
            Lokacja_i_Czas_Poziomu.enabled = false;
                  Level_To_Play = null;
                          Wybierz_Level[0].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
                         
        }
        

    }

    void LvL1(){
        click.Play();
          for(int i = 0; i < 8; i++){
          if(i == 1) continue;
           Wybierz_Level[i].GetComponent<Image>().sprite = Deselected;
           Wybierz_Level[i].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
        }
        if(Nazwa_Poziomu.enabled == false || Opis_Poziomu.enabled == false || Lokacja_i_Czas_Poziomu.enabled == false || przerywacz.enabled == false){
            Wybierz_Level[1].GetComponent<Image>().sprite = Selected;
            Nazwa_Poziomu.enabled = true;
            przerywacz.enabled = true;
            Opis_Poziomu.enabled = true;
            Lokacja_i_Czas_Poziomu.enabled = true;
            Nazwa_Poziomu.text = "'Prudential' - Porwanie";
        Lokacja_i_Czas_Poziomu.text = "Lokacja: Gmach 'Prudential', Warszawa 1944";
        Opis_Poziomu.text = "Po udanej obronie Hotelu Victorii i poznaniu Antoniego Chruściela, twoje życie obróciło się o 180 stopni jako że teraz zarządzasz oddziałem 'Papiloty', twoją pierwszą ważną operacją jest zdobycie zaopatrzenia dla oddziału, ale w trakcie dowiadujesz się czegoś ciekawego... ";
        Level_To_Play = "Level_1";
        Wybierz_Level[1].transform.GetChild(0).GetComponent<Text>().text = "ODZNACZ";
        } else{
            Wybierz_Level[1].GetComponent<Image>().sprite = Deselected;
             Nazwa_Poziomu.enabled = false;
            przerywacz.enabled = false;
            Opis_Poziomu.enabled = false;
            Lokacja_i_Czas_Poziomu.enabled = false;
                  Level_To_Play = null;
                          Wybierz_Level[1].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
                         
        }
        
    }

    void LvL2(){
        click.Play();
          for(int i = 0; i < 8; i++){
          if(i == 2) continue;
          Wybierz_Level[i].GetComponent<Image>().sprite = Deselected;
           Wybierz_Level[i].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
        }
        if(Nazwa_Poziomu.enabled == false || Opis_Poziomu.enabled == false || Lokacja_i_Czas_Poziomu.enabled == false || przerywacz.enabled == false){
            Wybierz_Level[2].GetComponent<Image>().sprite = Selected;
            Nazwa_Poziomu.enabled = true;
            przerywacz.enabled = true;
            Opis_Poziomu.enabled = true;
            Lokacja_i_Czas_Poziomu.enabled = true;
            Nazwa_Poziomu.text = "Hotel Victoria - Przesłuchanie";
        Lokacja_i_Czas_Poziomu.text = "Lokacja: Hotel Victoria (Baza)";
        Opis_Poziomu.text = "Po udanej akcji w Gmachu Prudential, przygotowywałeś się na przesłuchanie Maxa Dirkse, Masz nadzieję że wszystko pójdzie zgodnie z planem, ale czy tak będzie?";
        Level_To_Play = "Level_2";
        Wybierz_Level[2].transform.GetChild(0).GetComponent<Text>().text = "ODZNACZ";
        } else{
            Wybierz_Level[2].GetComponent<Image>().sprite = Deselected;
             Nazwa_Poziomu.enabled = false;
            przerywacz.enabled = false;
            Opis_Poziomu.enabled = false;
            Lokacja_i_Czas_Poziomu.enabled = false;
                  Level_To_Play = null;
                          Wybierz_Level[2].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
                         
        }
    }

    void LvL3(){
        click.Play();
         for(int i = 0; i < 8; i++){
          if(i == 3) continue;
          Wybierz_Level[i].GetComponent<Image>().sprite = Deselected;
           Wybierz_Level[i].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
        }
        if(Nazwa_Poziomu.enabled == false || Opis_Poziomu.enabled == false || Lokacja_i_Czas_Poziomu.enabled == false || przerywacz.enabled == false){
            Wybierz_Level[3].GetComponent<Image>().sprite = Selected;
            Nazwa_Poziomu.enabled = true;
            przerywacz.enabled = true;
            Opis_Poziomu.enabled = true;
            Lokacja_i_Czas_Poziomu.enabled = true;
            Nazwa_Poziomu.text = "Obrona Poczty";
        Lokacja_i_Czas_Poziomu.text = "Lokacja: Poczta Polska";
        Opis_Poziomu.text = "Gdy odbierałeś spokojnie poczte w placówce, pech chciał że znów znalazłeś się w środku wydarzeń. Twoim zadaniem jest obrona poczty ramie w ramie z Henrykiem Leliwa-Roycewiczem, i jego oddziałem 'Godziny W'";
        Level_To_Play = "Level_3";
        Wybierz_Level[3].transform.GetChild(0).GetComponent<Text>().text = "ODZNACZ";
        } else{
            Wybierz_Level[3].GetComponent<Image>().sprite = Deselected;
             Nazwa_Poziomu.enabled = false;
            przerywacz.enabled = false;
            Opis_Poziomu.enabled = false;
            Lokacja_i_Czas_Poziomu.enabled = false;
                  Level_To_Play = null;
                          Wybierz_Level[3].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
                         
        }
    }
    void LvL4(){
        click.Play();
           for(int i = 0; i < 8; i++){
          if(i == 4) continue;
          Wybierz_Level[i].GetComponent<Image>().sprite = Deselected;
           Wybierz_Level[i].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
        }
        if(Nazwa_Poziomu.enabled == false || Opis_Poziomu.enabled == false || Lokacja_i_Czas_Poziomu.enabled == false || przerywacz.enabled == false){
            Wybierz_Level[4].GetComponent<Image>().sprite = Selected;
            Nazwa_Poziomu.enabled = true;
            przerywacz.enabled = true;
            Opis_Poziomu.enabled = true;
            Lokacja_i_Czas_Poziomu.enabled = true;
            Nazwa_Poziomu.text = "Papiery bardzo wartościowe";
        Lokacja_i_Czas_Poziomu.text = "Lokacja: Polska Wytwórnia Papierów Wartościowych";
        Opis_Poziomu.text = "Po uporaniu się z Niemcami w Pocztcie Polskiej, doszły cię słuchy jakoby Niemcy planowali najazd na Wytwórnie papierów wartościowych,";
        Level_To_Play = "Level_4";
        Wybierz_Level[4].transform.GetChild(0).GetComponent<Text>().text = "ODZNACZ";
        } else{
            Wybierz_Level[4].GetComponent<Image>().sprite = Deselected;
             Nazwa_Poziomu.enabled = false;
            przerywacz.enabled = false;
            Opis_Poziomu.enabled = false;
            Lokacja_i_Czas_Poziomu.enabled = false;
                  Level_To_Play = null;
                          Wybierz_Level[4].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
                         
        }
    }

    void LvL5(){
        click.Play();
           for(int i = 0; i < 8; i++){
          if(i == 5) continue;
          Wybierz_Level[i].GetComponent<Image>().sprite = Deselected;
           Wybierz_Level[i].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
        }
        if(Nazwa_Poziomu.enabled == false || Opis_Poziomu.enabled == false || Lokacja_i_Czas_Poziomu.enabled == false || przerywacz.enabled == false){
            Wybierz_Level[5].GetComponent<Image>().sprite = Selected;
            Nazwa_Poziomu.enabled = true;
            przerywacz.enabled = true;
            Opis_Poziomu.enabled = true;
            Lokacja_i_Czas_Poziomu.enabled = true;
            Nazwa_Poziomu.text = "Pałac Krasińskich";
        Lokacja_i_Czas_Poziomu.text = "Lokacja: Pałac Krasińskich";
        Opis_Poziomu.text = "Celem tego poziomu jest obrona Pałacu z małą ilością wojska, czy będzie dla ciebie to problem? A może udowodnisz że jesteś wartościowym dowódcą i umiesz pomóc innym ludziom z batalionu Parasol";
        Level_To_Play = "Level_5";
        Wybierz_Level[5].transform.GetChild(0).GetComponent<Text>().text = "ODZNACZ";
        } else{
            Wybierz_Level[5].GetComponent<Image>().sprite = Deselected;
             Nazwa_Poziomu.enabled = false;
            przerywacz.enabled = false;
            Opis_Poziomu.enabled = false;
            Lokacja_i_Czas_Poziomu.enabled = false;
                  Level_To_Play = null;
                          Wybierz_Level[5].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
                         
        }
    }

    void LvL6(){
        click.Play();
           for(int i = 0; i < 8; i++){
          if(i == 6) continue;
          Wybierz_Level[i].GetComponent<Image>().sprite = Deselected;
           Wybierz_Level[i].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
        }
        if(Nazwa_Poziomu.enabled == false || Opis_Poziomu.enabled == false || Lokacja_i_Czas_Poziomu.enabled == false || przerywacz.enabled == false){
            Wybierz_Level[6].GetComponent<Image>().sprite = Selected;
            Nazwa_Poziomu.enabled = true;
            przerywacz.enabled = true;
            Opis_Poziomu.enabled = true;
            Lokacja_i_Czas_Poziomu.enabled = true;
            Nazwa_Poziomu.text = "Kasa oszczędności";
        Lokacja_i_Czas_Poziomu.text = "Lokacja: Bank Polski";
        Opis_Poziomu.text = "Niemcy przejęli Bank Polski i tam zarządzają swoimi finansami, to jest dość mocny cios w obie strony i zadanie twojej drużyny to odzyskanie i obrona gmachu Banku Polskiego. Jest to miejsce mocno strategiczne dlatego twoim planem jest przeniesienie tam swojej siedziby z hotelu Victoria.";
        Level_To_Play = "Level_6";
        Wybierz_Level[6].transform.GetChild(0).GetComponent<Text>().text = "ODZNACZ";
        } else{
            Wybierz_Level[6].GetComponent<Image>().sprite = Deselected;
             Nazwa_Poziomu.enabled = false;
            przerywacz.enabled = false;
            Opis_Poziomu.enabled = false;
            Lokacja_i_Czas_Poziomu.enabled = false;
                  Level_To_Play = null;
                          Wybierz_Level[6].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
                         
        }
    }

    void LvL7(){
        click.Play();
          for(int i = 0; i < 8; i++){
          if(i == 7) continue;
                   Debug.Log(i);

          Wybierz_Level[i].GetComponent<Image>().sprite = Deselected;
           Wybierz_Level[i].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
        }
        if(Nazwa_Poziomu.enabled == false || Opis_Poziomu.enabled == false || Lokacja_i_Czas_Poziomu.enabled == false || przerywacz.enabled == false){
            Wybierz_Level[7].GetComponent<Image>().sprite = Selected;
            Nazwa_Poziomu.enabled = true;
            przerywacz.enabled = true;
            Opis_Poziomu.enabled = true;
            Lokacja_i_Czas_Poziomu.enabled = true;
            Nazwa_Poziomu.text = "Zagłada i obóz";
        Lokacja_i_Czas_Poziomu.text = "Lokacja: Obóz Gęsiówka";
        Opis_Poziomu.text = "W tym miejscu pomagasz harcerskiemu batalionowi Armii Krajowej „Zośka” w odbiciu obozu i uratowaniu jeńców wojennych. Czy będzie to proste zadanie? Przekonaj się sam!";
        Level_To_Play = "Level_7";
        Wybierz_Level[7].transform.GetChild(0).GetComponent<Text>().text = "ODZNACZ";
        } else{
            Wybierz_Level[7].GetComponent<Image>().sprite = Deselected;
             Nazwa_Poziomu.enabled = false;
            przerywacz.enabled = false;
            Opis_Poziomu.enabled = false;
            Lokacja_i_Czas_Poziomu.enabled = false;
                  Level_To_Play = null;
                          Wybierz_Level[7].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
                         
        }
    }

    void LvL8(){
       click.Play();
           for(int i = 0; i < 8; i++){
          if(i == 8) continue;
          Wybierz_Level[i].GetComponent<Image>().sprite = Deselected;
           Wybierz_Level[i].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
        }
        if(Nazwa_Poziomu.enabled == false || Opis_Poziomu.enabled == false || Lokacja_i_Czas_Poziomu.enabled == false || przerywacz.enabled == false){
            Wybierz_Level[8].GetComponent<Image>().sprite = Selected;
            Nazwa_Poziomu.enabled = true;
            przerywacz.enabled = true;
            Opis_Poziomu.enabled = true;
            Lokacja_i_Czas_Poziomu.enabled = true;
            Nazwa_Poziomu.text = "Kasa oszczędności";
        Lokacja_i_Czas_Poziomu.text = "Lokacja: Bank Polski";
        Opis_Poziomu.text = "Niemcy przejęli Bank Polski i tam zarządzają swoimi finansami, to jest dość mocny cios w obie strony i zadanie twojej drużyny to odzyskanie i obrona gmachu Banku Polskiego. Jest to miejsce mocno strategiczne dlatego twoim planem jest przeniesienie tam swojej siedziby z hotelu Victoria.";
        Level_To_Play = "Level_6";
        Wybierz_Level[8].transform.GetChild(0).GetComponent<Text>().text = "ODZNACZ";
        } else{
            Wybierz_Level[8].GetComponent<Image>().sprite = Deselected;
             Nazwa_Poziomu.enabled = false;
            przerywacz.enabled = false;
            Opis_Poziomu.enabled = false;
            Lokacja_i_Czas_Poziomu.enabled = false;
                  Level_To_Play = null;
                          Wybierz_Level[8].transform.GetChild(0).GetComponent<Text>().text = "WYBIERZ";
                         
        }
    }
}
