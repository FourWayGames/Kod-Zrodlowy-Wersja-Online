using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;
using UnityEngine.EventSystems;
using TMPro;
using System;
using Random=UnityEngine.Random;
using UnityEngine;
//Ten kod zarządza działaniem całego poziomu
public class ManagerForSecondProject : MonoBehaviour
{ 
    public static int RZ, MECH, AMM, Enemy_Defeated, SCORE, Player_Defeated;
    public float GM_time;
    public Text txt_RZ, txt_MECH, txt_AMMO, txt_time, txt_EnemyCounter, txt_SCORE_W, txt_SCORE_L, txt_Player_Defeated_W, txt_Player_Defeated_L;
    public Tilemap World, Hover, HoverRange;
    public GameObject INTRO_CARD, TALK_CARD, BACK_TO_MENU, OPT_MENU;
    public GameObject[] spawner;
    public Button BackToMenu_YES, MENU_UST, BACK_TO_ESC, Lost_BackToMenu, Lost_TryAgain, Won_BackToMenu, Won_TryAgain, Won_NextLevel;
    public Tile[] TileSet;
    private int enemyCounter, WavesComplete, PlayMusic;
    public int EnemyPerWave, WavesToComplete;
    public static bool MB_Ex, CanSpawn, INTRO, TUTORIAL, DM, DP, Ending_Sequence, BlockForCutscene, Block;
        public Grid grid;
        public static AudioSource SoundTrack;
        public AudioClip[] Soundtrack_List;
        public AudioSource Click;
        public static float SpawnTime;
        public TMP_Text Version;
        private Scene scene;
         private Vector3Int previousMousePos = new Vector3Int();
              private System.Action OdegrajRaz { get; set; } = null;
         GraphicRaycaster m_Raycaster;
    PointerEventData m_PointerEventData;
    EventSystem m_EventSystem;

    void Start()
    {
        Version.text = "Beta 0.9.2";
        SCORE = 200;
        SoundTrack = GetComponent<AudioSource>();
        Enemy_Defeated = 0;
        Time.timeScale = 1; //to na wszelki, bo po wyjsciu do menu timescale jest 0
        MENU_UST.onClick.AddListener(MENU_UST_CD);
        BACK_TO_ESC.onClick.AddListener(Back);
        BackToMenu_YES.onClick.AddListener(BTM_MANAGER_YES);
        Lost_BackToMenu.onClick.AddListener(BTM_MANAGER_YES);
        Lost_TryAgain.onClick.AddListener(BTM_MANAGER_LTA);   
        Won_BackToMenu.onClick.AddListener(BTM_MANAGER_YES);
        Won_TryAgain.onClick.AddListener(BTM_MANAGER_LTA);
        Won_NextLevel.onClick.AddListener(BTM_MANAGER_NL);
         m_Raycaster = GameObject.Find("Canvas").GetComponent<GraphicRaycaster>();
        m_EventSystem = GameObject.Find("EventSystem").GetComponent<EventSystem>();
        scene = SceneManager.GetActiveScene();
        if(scene.name == "Tutorial_Level"){
            AI_CONTROLLER.Liczba_WP = 5;
            enemyCounter = 0;
                    TUTORIAL = false;
            DIALOG_MANAGER.NR_DIALOGU = 1;
  INTRO = true;
       MB_Ex = true; // nie używamy już tego
        RZ = 30;
        AMM = 30;
        MECH = 0;
       
        SpawnTime = 5f;
             //TODO: Zmienić to na Switch'e
        }else if(scene.name == "Level_1"){
            AI_CONTROLLER.Liczba_WP = 3;
            enemyCounter = 0;
            DIALOG_MANAGER.NR_DIALOGU = 47;
            RZ = 45;
            AMM = 45;
            MECH = 0;
           
            SpawnTime = 5f;
        }else if(scene.name == "Level_2"){
            AI_CONTROLLER.Liczba_WP = 6;
            AI_CONTROLLER.Liczba_WP2 = 4;
            enemyCounter = 0;
            DIALOG_MANAGER.NR_DIALOGU = 56;
            RZ = 45;
            AMM = 45;
            MECH = 0;
           
            SpawnTime = 5f;
        }else if(scene.name == "Level_3"){
            AI_CONTROLLER.Liczba_WP = 4;
            AI_CONTROLLER.Liczba_WP2 = 2;
            enemyCounter = 0;
            DIALOG_MANAGER.NR_DIALOGU = 77;
            RZ = 45;
            AMM = 45;
            MECH = 0;
           
            SpawnTime = 5f;
        }else if(scene.name == "Level_4"){
            AI_CONTROLLER.Liczba_WP = 9;
            AI_CONTROLLER.Liczba_WP2 = 3;
            enemyCounter = 0;
            DIALOG_MANAGER.NR_DIALOGU = 97;
            RZ = 45;
            AMM = 45;
            MECH = 0;
            
            SpawnTime = 4.7f;
        }else if(scene.name == "Level_5"){
            AI_CONTROLLER.Liczba_WP = 6;
            enemyCounter = 0;
            DIALOG_MANAGER.NR_DIALOGU = 105;
            RZ = 45;
            AMM = 45;
            MECH = 0;
            
            SpawnTime = 4.5f;
        }else if(scene.name == "Level_6"){
            AI_CONTROLLER.Liczba_WP = 3;
            AI_CONTROLLER.Liczba_WP2 = 1;
            enemyCounter = 0;
            DIALOG_MANAGER.NR_DIALOGU = 111;
            RZ = 50;
            AMM = 80;
            MECH = 150;
            
            SpawnTime = 4.4f;
        }else if(scene.name == "Level_7"){
            AI_CONTROLLER.Liczba_WP = 6;
            AI_CONTROLLER.Liczba_WP2 = 3;
            enemyCounter = 0;
            DIALOG_MANAGER.NR_DIALOGU = 117;
            RZ = 45;
            AMM = 45;
            MECH = 0;
           
            SpawnTime = 4.3f;
        }else if(scene.name == "Level_8"){
            AI_CONTROLLER.Liczba_WP = 2;
            AI_CONTROLLER.Liczba_WP2 = 3;
            AI_CONTROLLER.Liczba_WP3 = 4;
            enemyCounter = 0;
            DIALOG_MANAGER.NR_DIALOGU = 123;
            RZ = 120;
            AMM = 120;
            MECH = 120;
            
            SpawnTime = 3.9f;
        }
      
        
                

                          // StartCoroutine(SpawnWaves());

           
    }

    void Update()
    {
    
        if(PlayMusic == 1){
        StartCoroutine(playAudioSequentially());
        }
        Raycaster();

        if(Enemy_Defeated == EnemyPerWave){
              switch(scene.name){
              case "Tutorial_Level":
              Levels_Manager.LVL1 = true;
              Levels_Manager.LVL0_ShowScore = true;
              PlayerPrefs.SetInt("lvl1", 1);  //PlayerPrefs nie wspiera Booleana więc standardowo: 1-true 0-false
              PlayerPrefs.SetInt("lvl0_scr", 1);
              break;
              case "Level_1":
              Levels_Manager.LVL2 = true;
               Levels_Manager.LVL1_ShowScore = true;
                PlayerPrefs.SetInt("lvl2", 1);
              PlayerPrefs.SetInt("lvl1_scr", 1);
              break;
              case "Level_2":
              Levels_Manager.LVL3 = true;
               Levels_Manager.LVL2_ShowScore = true;
                PlayerPrefs.SetInt("lvl3", 1);
              PlayerPrefs.SetInt("lvl2_scr", 1);
              break;
              case "Level_3":
              Levels_Manager.LVL4 = true;
               Levels_Manager.LVL3_ShowScore = true;
                PlayerPrefs.SetInt("lvl4", 1);
              PlayerPrefs.SetInt("lvl3_scr", 1);
              break;
              case "Level_4":
              Levels_Manager.LVL5 = true;
               Levels_Manager.LVL4_ShowScore = true;
                PlayerPrefs.SetInt("lvl5", 1);
              PlayerPrefs.SetInt("lvl4_scr", 1);
              break;
              case "Level_5":
              Levels_Manager.LVL6 = true;
               Levels_Manager.LVL5_ShowScore = true;
                PlayerPrefs.SetInt("lvl6", 1);
              PlayerPrefs.SetInt("lvl5_scr", 1);
              break;
              case "Level_6":
              Levels_Manager.LVL7 = true;
               Levels_Manager.LVL6_ShowScore = true;
                PlayerPrefs.SetInt("lvl7", 1);
              PlayerPrefs.SetInt("lvl6_scr", 1);
              break;
              case "Level_7":
              Levels_Manager.LVL8 = true;
               Levels_Manager.LVL7_ShowScore = true;
                PlayerPrefs.SetInt("lvl8", 1);
              PlayerPrefs.SetInt("lvl7_scr", 1);
              break;
              case "Level_8":
               Levels_Manager.LVL8_ShowScore = true;
              PlayerPrefs.SetInt("lvl8_scr", 1);
              break;
              }
            if(DIALOG_MANAGER.NR_DIALOGU == 35){
                TALK_CARD.SetActive(true);
            } if(DIALOG_MANAGER.NR_DIALOGU == 54){
                TALK_CARD.SetActive(true);
            }if(DIALOG_MANAGER.NR_DIALOGU == 72){
                TALK_CARD.SetActive(true);
            }if(DIALOG_MANAGER.NR_DIALOGU == 95){
                TALK_CARD.SetActive(true);
            }if(DIALOG_MANAGER.NR_DIALOGU == 102){
                TALK_CARD.SetActive(true);
            }if(DIALOG_MANAGER.NR_DIALOGU == 109){
                TALK_CARD.SetActive(true);
            }if(DIALOG_MANAGER.NR_DIALOGU == 114){
                TALK_CARD.SetActive(true);
            }if(DIALOG_MANAGER.NR_DIALOGU == 120){
                TALK_CARD.SetActive(true);
            }if(DIALOG_MANAGER.NR_DIALOGU == 126){
                TALK_CARD.SetActive(true);
            }
            Time.timeScale = 0;
           //WinPanel.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(!BACK_TO_MENU.activeSelf && !OPT_MENU.activeSelf){
                BACK_TO_MENU.SetActive(true);
                //SoundTrack.Pause();
                Time.timeScale = 0;
            }else if(BACK_TO_MENU.activeSelf){
                BACK_TO_MENU.SetActive(false);
                //SoundTrack.UnPause();
                Time.timeScale = 1;
            }else if(!BACK_TO_MENU.activeSelf && OPT_MENU.activeSelf){
                OPT_MENU.SetActive(false);
                SoundTrack.UnPause();
                Time.timeScale = 0;
            }
            
        }
        if(INTRO){
            DIALOG_MANAGER.LVL0_DIALOG1 = true;
        }
        if(TALK_CARD.activeSelf){
            if(DIALOG_MANAGER.NR_DIALOGU == 28 || DIALOG_MANAGER.NR_DIALOGU == 30){
                BlockForCutscene = false;
            }else{
                
                Hover.SetTile(previousMousePos, null); 
            BlockForCutscene = true;
            }
            
        }
        if(!TALK_CARD.activeSelf){
            if(!TUTORIAL){
              PlayMusic++; 
            }
            
       var ts = TimeSpan.FromSeconds(GM_time);
        if(GM_time > 0){
  GM_time-= Time.deltaTime;
        }
        if(GM_time <= 0){
            if(OdegrajRaz != null) OdegrajRaz.Invoke();
        }
      
        BlockForCutscene = false;
        txt_time.text = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
       
           
        }
           
    txt_SCORE_W.text = "Punkty: " + SCORE.ToString();
    txt_Player_Defeated_W.text = "Stracone jednostki: " + Player_Defeated.ToString();           
    txt_SCORE_L.text = "Punkty: " + SCORE.ToString();
    txt_Player_Defeated_L.text = "Stracone jednostki: " + Player_Defeated.ToString();  
    txt_RZ.text = RZ.ToString();
    txt_AMMO.text = AMM.ToString();
    txt_MECH.text = MECH.ToString();
     txt_EnemyCounter.text = Enemy_Defeated.ToString() + "/" + WavesToComplete.ToString();
     if(!BlockForCutscene){
  if(ShopMenu.ShopAble == true && (!DM) && !Block){
                    Selecter();
        }else{
            
            Hover.ClearAllTiles();
            HoverRange.ClearAllTiles();
        }
     }
      

     if(TUTORIAL == true){
         
        //Time.timeScale = 0;
         TALK_CARD.SetActive(true);
         
         

     }          
     
     if(Ending_Sequence){
         
         TALK_CARD.SetActive(true);
     }
     switch(scene.name){
         case "Tutorial_Level":
         
         Levels_Manager.LVL0_Score = SCORE;
         
         
         break;
         case "Level_1":
        
         Levels_Manager.LVL1_Score = SCORE;
         
         break;
         case "Level_2":
         
         Levels_Manager.LVL2_Score = SCORE;
         
         break;
         case "Level_3":
         
         Levels_Manager.LVL3_Score = SCORE;
         
         break;
         case "Level_4":
        
         Levels_Manager.LVL4_Score = SCORE;
        
         break;
         case "Level_5":
         
         Levels_Manager.LVL5_Score = SCORE;
       
         break;
         case "Level_6":
        
         Levels_Manager.LVL6_Score = SCORE;
        
         break;
         case "Level_7":
         
         Levels_Manager.LVL7_Score = SCORE;
        
         break;
         case "Level_8":
       
         Levels_Manager.LVL8_Score = SCORE;
         
         break;
     }
       //Nie mam pojęcia jak naprawić tą głupią otoczke, nie mam też czasu bo zaraz oddajemy, więc zrobimy to tak:
if(DIALOG_MANAGER.NR_DIALOGU == 29 || DIALOG_MANAGER.NR_DIALOGU == 31 ){
  
    HoverRange.ClearAllTiles();
}
    }
    private void Awake(){
        OdegrajRaz = ActuallySpawnWaves;
    }
    private void BTM_MANAGER_YES(){
        Click.Play();
      SceneManager.LoadScene("MM");
    }
    private void Back(){
        Click.Play();
        BACK_TO_MENU.SetActive(true);
      OPT_MENU.SetActive(false);
    }
   IEnumerator playAudioSequentially()
{
    yield return null;

    
    for (int i = 0; i < Soundtrack_List.Length; i++)
    {
        SoundTrack.clip = Soundtrack_List[i];
        SoundTrack.Play();

        while (SoundTrack.isPlaying)
        {
            yield return null;
        }

        
    }
}
    private void BTM_MANAGER_NL(){
        Click.Play();
        Scene scene = SceneManager.GetActiveScene();
        switch(scene.name){
           case "Tutorial_Level":
            SceneManager.LoadScene("Level_1");
           break;
           case "Level_1":
           SceneManager.LoadScene("Level_2");
           break;
           case "Level_2":
           SceneManager.LoadScene("Level_3");
           break;
           case "Level_3":
           SceneManager.LoadScene("Level_4");
           break;
           case "Level_4":
           SceneManager.LoadScene("Level_5");
           break;
           case "Level_5":
           SceneManager.LoadScene("Level_6");
           break;
           case "Level_6":
           SceneManager.LoadScene("Level_7");
           break;
           case "Level_7":
           SceneManager.LoadScene("Level_8");
           break;
           
        }
       
    }

    private void MENU_UST_CD(){
  Click.Play();
      OPT_MENU.SetActive(true);
      BACK_TO_MENU.SetActive(false);
    }
    private void BTM_MANAGER_LTA(){
        Click.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

     IEnumerator SpawnWaves(){   

                   while(WavesComplete <= WavesToComplete){
                       if(spawner.Length == 3){
                               var Random_Spawner = Random.Range(1,4);
                           
                           var bruh = spawner[Random.Range(0,3)];
                          
                           if(Random_Spawner == 1){
                                   var d = Instantiate(Resources.Load("Tank_GER"), bruh.transform.position, bruh.transform.rotation);
           d.name = "Tank" + bruh.transform.name;
                           }   
                           if(Random_Spawner == 0){
                      var d = Instantiate(Resources.Load("normalsol_GER"), bruh.transform.position, bruh.transform.rotation);
           d.name =  bruh.transform.name;
                           }
                              
                               /*
var e = Instantiate(Resources.Load("normalsol_GER"), bruh.transform.position, bruh.transform.rotation);
           e.name = bruh.transform.name;
                               */
                           

                       }
                       if(spawner.Length == 2){
                           var bruh = spawner[Random.Range(0,2)];
                           if(scene.name == "Level_2"){
                                var Random_Spawner = Random.Range(1,3);
                                Debug.Log(Random_Spawner);
                                if(Random_Spawner == 1){
                                  var d = Instantiate(Resources.Load("normalsol_GER"), bruh.transform.position, bruh.transform.rotation);
           d.name = bruh.transform.name;
                           }   
                           if(Random_Spawner == 2){
    var d = Instantiate(Resources.Load("normalsol_GER"), bruh.transform.position, bruh.transform.rotation);
           d.name = bruh.transform.name;
                           }
                           }
                           if(scene.name != "Level_2") {
                               var Random_Spawner = Random.Range(1,3);
                                if(Random_Spawner == 1){
                                  var d = Instantiate(Resources.Load("Tank_GER"), bruh.transform.position, bruh.transform.rotation);
           d.name = "Tank" + bruh.transform.name;
                           }   
                           if(Random_Spawner == 2){
    var d = Instantiate(Resources.Load("normalsol_GER"), bruh.transform.position, bruh.transform.rotation);
           d.name = bruh.transform.name;
                           }
                           }
                              
                               
                               /*
var e = Instantiate(Resources.Load("normalsol_GER"), bruh.transform.position, bruh.transform.rotation);
           e.name = bruh.transform.name;
                               */
                           

                       }
                         if(spawner.Length == 1){
                             if(scene.name == "Tutorial_Level" || scene.name == "Level_1"){
                                        var d = Instantiate(Resources.Load("normalsol_GER"), spawner[0].transform.position, spawner[0].transform.rotation);
           d.name = spawner[0].transform.name;
                             }
                             
                    if(scene.name == "Level_5"){
                               var Random_Spawner = Random.Range(0,2);
                                if(Random_Spawner == 1){
                               var d = Instantiate(Resources.Load("Tank_GER"), spawner[0].transform.position,  spawner[0].transform.rotation);
           d.name = "Tank" + spawner[0].transform.name;
                           }   
                           if(Random_Spawner == 2){
                          var d = Instantiate(Resources.Load("normalsol_GER"), spawner[0].transform.position, spawner[0].transform.rotation);
           d.name = spawner[0].transform.name;
                           }
                           }
                              // var randomizer = Random.Range (0,5);
                               //if(randomizer > 2){
                        
                               /*
var e = Instantiate(Resources.Load("normalsol_GER"), spawner[0].transform.position, spawner[0].transform.rotation);
           e.name = spawner[0].transform.name;
                               */
                           //}
                       }
           
                           yield return new WaitForSeconds(SpawnTime);
                                         enemyCounter++;
                   }



      

     }

     void ActuallySpawnWaves(){
         OdegrajRaz = null;
         StartCoroutine(SpawnWaves());
     }

     void Raycaster(){
         m_PointerEventData = new PointerEventData(m_EventSystem);
            
            m_PointerEventData.position = Input.mousePosition;

            
            List<RaycastResult> results = new List<RaycastResult>();

            
            m_Raycaster.Raycast(m_PointerEventData, results);

            
            foreach (RaycastResult result in results)
            {
               
                if(result.gameObject.tag == "buttn"){
                    DM = true;
                    break;
                }else if(result.gameObject.tag != "buttn"){
                    DM = false;
                    
                }
                if(result.gameObject.layer == 5){
                  DP = true;
                  break;
                } else if(result.gameObject.layer != 5){
                    DP = false;
                }
                
            }
     }
    

    void Selecter(){
Vector3Int mousePos = GetMousePosition();
    var Tile_type = World.GetTile(mousePos);
        if (!mousePos.Equals(previousMousePos)) {
            Hover.SetTile(previousMousePos, null);
            HoverRange.SetTile(previousMousePos, null); 
            if((ShopMenu.NormalSoldier && RZ >= 15) && AMM >= 15){
                          Hover.SetTile(mousePos, TileSet[2]);
                          TileSet[3].transform = Matrix4x4.Scale(new Vector3(1f,1f,0));
                          HoverRange.SetTile(mousePos, TileSet[3]);
            }
            if((ShopMenu.SztormSoldier && RZ >= 30) && AMM >= 30){
                          Hover.SetTile(mousePos, TileSet[5]);
                          TileSet[3].transform = Matrix4x4.Scale(new Vector3(1.35f,1.35f,0));
                          HoverRange.SetTile(mousePos, TileSet[3]);
            }
             if((ShopMenu.SnajperSoldier && RZ >= 10) && AMM >= 40){
                          Hover.SetTile(mousePos, TileSet[4]);
                           TileSet[3].transform = Matrix4x4.Scale(new Vector3(1.8f,1.8f,0));
                          HoverRange.SetTile(mousePos, TileSet[3]);
            }
            if((ShopMenu.MinaEntity && MECH >= 50)){
                          Hover.SetTile(mousePos, TileSet[6]);
                          //HoverRange.SetTile(mousePos, TileSet[3]);
            }
            if((ShopMenu.CzolgEntity && MECH >= 75) && AMM >= 30){
                          Hover.SetTile(mousePos, TileSet[7]);
                           TileSet[3].transform = Matrix4x4.Scale(new Vector3(1.2f,1.2f,0));
                          HoverRange.SetTile(mousePos, TileSet[3]);
            }
            previousMousePos = mousePos;
        }
           
        if (Input.GetMouseButtonDown(0) && DP == false) {
             RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
             if(Tile_type.name != "Sprite-0003" && (Tile_type.name == "droga2.2" || Tile_type.name == "droga3.2" || Tile_type.name == "droga4.2" || Tile_type.name == "path")){
                 if(hit.collider == null){
if(ShopMenu.MinaEntity && MECH >= 50){
                  
                MECH -= 50;
               DIALOG_MANAGER.PJ++;
                Vector3 d = new Vector3(mousePos.x, mousePos.y, 0.6f);
                var spawnPoint = grid.GetCellCenterWorld(grid.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition)));
           var i = Instantiate(Resources.Load("mina_POL"), spawnPoint, transform.rotation);
           i.name = "minaEnt_POL";
            }
                 }
               
            }
            if(Tile_type.name == "Sprite-0003" || Tile_type.name == "Ulepszacze_0" || Tile_type.name == "Ulepszacze_1" || Tile_type.name == "Ulepszacze_2"){

            if(hit.collider == null){
            if(ShopMenu.NormalSoldier && (RZ >= 15 && AMM >= 15)){
                RZ -= 15;
                AMM -= 15;
                DIALOG_MANAGER.PJ++;
                Vector3 d = new Vector3(mousePos.x, mousePos.y, 0.6f);
                var spawnPoint = grid.GetCellCenterWorld(grid.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition)));
           var i = Instantiate(Resources.Load("normalsol_POL"), spawnPoint, transform.rotation);
           i.name = "pistolsol_POL"; //usuwam (Clone) bo przeszkadza w innym skrypcie
            }
             if(ShopMenu.SztormSoldier && (RZ >= 30 && AMM >= 30)){
                RZ -= 30;
                AMM -= 30;
                DIALOG_MANAGER.PJ++;
                Vector3 d = new Vector3(mousePos.x, mousePos.y, 0.6f);
                var spawnPoint = grid.GetCellCenterWorld(grid.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition)));
           var i = Instantiate(Resources.Load("Szturmsol_POL"), spawnPoint, transform.rotation);
           i.name = "sztormsol_POL";
            }
            if(ShopMenu.SnajperSoldier && (RZ >= 10 && AMM >= 40)){
                RZ -= 10;
                AMM -= 40;
                DIALOG_MANAGER.PJ++;
                Vector3 d = new Vector3(mousePos.x, mousePos.y, 0.6f);
                var spawnPoint = grid.GetCellCenterWorld(grid.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition)));
           var i = Instantiate(Resources.Load("snipersol_POL"), spawnPoint, transform.rotation);
           i.name = "snipersol_POL";
            }
            
            if(ShopMenu.CzolgEntity && (MECH >= 50 && AMM >= 30)){
                MECH -= 75;
                AMM -= 30;
                DIALOG_MANAGER.PJ++;
                Vector3 d = new Vector3(mousePos.x, mousePos.y, 0.6f);
                var spawnPoint = grid.GetCellCenterWorld(grid.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition)));
           var i = Instantiate(Resources.Load("czolg_POL"), spawnPoint, transform.rotation);
           i.name = "czolgEnt_POL";
            }
            
            }
           
            }
           
            
            
        }
         
        
        if (Input.GetMouseButtonDown(1)) {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if((hit.collider != null) && (hit.collider.gameObject.GetComponent<HEALTH_SCRIPT>().Health == hit.collider.gameObject.GetComponent<HEALTH_SCRIPT>().FullHealth)){
                Debug.Log(hit.collider.name);
switch(hit.collider.name){
               case "pistolsol_POL":
               DIALOG_MANAGER.PJ--;
     RZ += 15;
     AMM += 15;
    Destroy(hit.transform.gameObject);
    break;
     case "sztormsol_POL":
               DIALOG_MANAGER.PJ--;
     RZ += 30;
     AMM += 30;
    Destroy(hit.transform.gameObject);
    break;
     case "snipersol_POL":
               DIALOG_MANAGER.PJ--;
     RZ += 10;
     AMM += 40;
    Destroy(hit.transform.gameObject);
    break;
     case "minaEnt_POL":
               DIALOG_MANAGER.PJ--;
     MECH += 50;
    Destroy(hit.transform.gameObject);
    break;
     case "czolgEnt_POL":
               DIALOG_MANAGER.PJ--;
     MECH += 75;
     AMM += 30;
    Destroy(hit.transform.gameObject);
    break;
            }
            }
            

    
    

                 
            //World.SetTile(mousePos, null); 
            
        }

          if(Tile_type != null){
if(Tile_type.name != "Sprite-0003" && !ShopMenu.MinaEntity){ //Tym stawiam jednostki na trawie wyłączając stawianie na ulicy
            Hover.SetTile(previousMousePos, null); 
            HoverRange.SetTile(previousMousePos, null); 
            Hover.SetTile(mousePos, TileSet[1]);
            previousMousePos = mousePos;  
         }if((Tile_type.name == "Sprite-0003" && Tile_type.name != "GrassBlocker") && ShopMenu.MinaEntity){ //Tym stawiam miny na ulice, wyłączając stawianie na trawie + GrassBlocker bo miny mogły 
            Hover.SetTile(previousMousePos, null);                                                          //Pojawiać się na drzewach przez ułamek sekundy
            HoverRange.SetTile(previousMousePos, null); 
            Hover.SetTile(mousePos, TileSet[1]);
            previousMousePos = mousePos;  
         }
          }
    
         

    }

    
    

    Vector3Int GetMousePosition () {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return grid.WorldToCell(mouseWorldPos);
    }

    
}
