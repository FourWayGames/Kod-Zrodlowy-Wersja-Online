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
        /*if(LVL0_Score >= LVL0_HighScore){
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
        }*/
        
        /*if(Input.GetKeyDown("1")){ //do debugowania, wykomentowa?? na release....
            
            LVL1 = true;
        }
        if(Input.GetKeyDown("2")){
            LVL2 = true;
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
            LVL8 = true;
        }*/
        
    
        if(LVL1 == true){
            
            Wybierz_Level[1].transform.GetChild(2).gameObject.SetActive(false);
            Wybierz_Level[1].interactable = true;
        }
        if(LVL2 == true){
            Wybierz_Level[2].transform.GetChild(2).gameObject.SetActive(false);
            Wybierz_Level[2].interactable = true;
        }
         if(LVL3 == true){
            Wybierz_Level[3].transform.GetChild(2).gameObject.SetActive(false);
            Wybierz_Level[3].interactable = true;
        }
         if(LVL4 == true){
            Wybierz_Level[4].transform.GetChild(2).gameObject.SetActive(false);
            Wybierz_Level[4].interactable = true;
        }
         if(LVL5 == true){
            Wybierz_Level[5].transform.GetChild(2).gameObject.SetActive(false);
            Wybierz_Level[5].interactable = true;
        }
         if(LVL6 == true){
            Wybierz_Level[6].transform.GetChild(2).gameObject.SetActive(false);
            Wybierz_Level[6].interactable = true;
        }
         if(LVL7 == true){
            Wybierz_Level[7].transform.GetChild(2).gameObject.SetActive(false);
            Wybierz_Level[7].interactable = true;
        }if(LVL8 == true){
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

       /* if(LVL0_ShowScore == true){
            
          Wybierz_Level[0].transform.GetChild(2).gameObject.SetActive(true);
        }
        if(LVL1_ShowScore == true){
            Wybierz_Level[1].transform.GetChild(3).gameObject.SetActive(true);
        }
        if(LVL2_ShowScore == true){
            Wybierz_Level[2].transform.GetChild(3).gameObject.SetActive(true);
        }
        if(LVL3_ShowScore == true){
            Wybierz_Level[3].transform.GetChild(3).gameObject.SetActive(true);
        }
        if(LVL4_ShowScore == true){
            Wybierz_Level[4].transform.GetChild(3).gameObject.SetActive(true);
        }
        if(LVL5_ShowScore == true){
            Wybierz_Level[5].transform.GetChild(3).gameObject.SetActive(true);
        }
        if(LVL6_ShowScore == true){
            Wybierz_Level[6].transform.GetChild(3).gameObject.SetActive(true);
        }
        if(LVL7_ShowScore == true){
            Wybierz_Level[7].transform.GetChild(3).gameObject.SetActive(true);
        }
        if(LVL8_ShowScore == true){
            Wybierz_Level[8].transform.GetChild(3).gameObject.SetActive(true);
        }*/
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
        Opis_Poziomu.text = "Nazywasz si?? Kamil, od pewnego czasu kr????y??y plotki jakoby Niemcy mieli najecha?? na Hotel Victorie, a los chcia??, ??e akurat znalaz??e?? si?? w ??rodku wydarze?? jako dow??dca, musisz odepchn???? Niemc??w za wszelk?? cene!";
        Level_To_Play = "IntroScene";
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
          for(int i = 0; i < 9; i++){
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
        Opis_Poziomu.text = "Po udanej obronie Hotelu Victorii i poznaniu Antoniego Chru??ciela, twoje ??ycie obr??ci??o si?? o 180 stopni jako ??e teraz zarz??dzasz oddzia??em 'Papiloty', twoj?? pierwsz?? wa??n?? operacj?? jest zdobycie zaopatrzenia dla oddzia??u, ale w trakcie dowiadujesz si?? czego?? ciekawego... ";
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
          for(int i = 0; i < 9; i++){
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
            Nazwa_Poziomu.text = "Hotel Victoria - Przes??uchanie";
        Lokacja_i_Czas_Poziomu.text = "Lokacja: Hotel Victoria (Baza)";
        Opis_Poziomu.text = "Po udanej akcji w Gmachu Prudential, przygotowywa??e?? si?? na przes??uchanie Maxa Dirkse, Masz nadziej?? ??e wszystko p??jdzie zgodnie z planem, ale czy tak b??dzie?";
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
         for(int i = 0; i < 9; i++){
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
        Opis_Poziomu.text = "Henryk Leliwa-Roycewicz z??o??y?? ci propozycje nie do odrzucenia, ma to zwi??zek ze wzmocnionym atakiem Niemc??w na Warszawe";
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
           for(int i = 0; i < 9; i++){
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
            Nazwa_Poziomu.text = "Papiery bardzo warto??ciowe";
        Lokacja_i_Czas_Poziomu.text = "Lokacja: Polska Wytw??rnia Papier??w Warto??ciowych";
        Opis_Poziomu.text = "Po uporaniu si?? z Niemcami w Potczcie Polskiej, dosz??y ci?? s??uchy jakoby Niemcy planowali najazd na Wytw??rnie papier??w warto??ciowych,";
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
           for(int i = 0; i < 9; i++){
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
            Nazwa_Poziomu.text = "Pa??ac Krasi??skich";
        Lokacja_i_Czas_Poziomu.text = "Lokacja: Pa??ac Krasi??skich";
        Opis_Poziomu.text = "Zn??w nadszed?? czas na pomoc, tym razem przy Pa??acu Krasi??skich, gdzie musisz odeprze?? nadchodz??cych Niemc??w!";
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
           for(int i = 0; i < 9; i++){
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
            Nazwa_Poziomu.text = "Kasa oszcz??dno??ci";
        Lokacja_i_Czas_Poziomu.text = "Lokacja: Bank Polski";
        Opis_Poziomu.text = "Niemcy zamierzaj?? przej???? Bank Polski, nie mo??esz im na to pozwoli??!";
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
          for(int i = 0; i < 9; i++){
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
            Nazwa_Poziomu.text = "Zag??ada i ob??z";
        Lokacja_i_Czas_Poziomu.text = "Lokacja: Ob??z G??si??wka";
        Opis_Poziomu.text = "Batalion 'Zo??ka' Odbili w??a??nie g??si??wke i poprosili ci?? o pomoc w odparciu pozosta??ych Niemc??w! Czujesz ??e nie b??dzie to proste zadanie...";
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
           for(int i = 0; i <= 9; i++){
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
            Nazwa_Poziomu.text = "Nauka to klucz";
        Lokacja_i_Czas_Poziomu.text = "Lokacja: Politechnika Warszawska";
        Opis_Poziomu.text = "Tw??j batalion zyska?? tak du???? s??awe, ??e niekt??rzy zacz??li prosi?? cie o pomoc, uczniowie Politechniki Warszawskiej pok??adaj?? w tobie ca???? nadzieje! czy zdo??asz ich obroni???.";
        Level_To_Play = "Level_8";
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
