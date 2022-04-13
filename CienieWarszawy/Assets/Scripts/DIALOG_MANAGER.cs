using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;


public class DIALOG_MANAGER : MonoBehaviour
{
    public Text TXT_autor, TXT_dialog;
    public GameObject Aktor1, Aktor2, PANEL_POMOCY, MAPA, PANEL_GORNY, ENEMYCOUNTER_GO, RESOURCES_GO, TIME_GO, HP_GO, WinPanel;
    public Animator FadeOut;
    public Button Skip_text, Auto_mover, Pomoc;
    public static bool LVL0_DIALOG1, LVL0_DIALOG2, LVL0_DIALOG3, LVL3_DIALOGT, LVL1_DIALOG1, LVL1_DIALOG2, LVL2_DIALOG1, LVL2_DIALOG2, LVL3_DIALOG1, LVL3_DIALOG2, LVL4_DIALOG1, LVL4_DIALOG2, LVL5_DIALOG1, LVL5_DIALOG2, LVL6_DIALOG1, LVL6_DIALOG2, LVL7_DIALOG1, LVL7_DIALOG2, LVL8_DIALOG1, LVL8_DIALOG2;
    private bool AUTO_ENABLE, TUTORIAL_BLOCKER;
    public static int NR_DIALOGU, PJ; 
    private Coroutine A;
    

    
    void Start()
    {
        
        Skip_text.onClick.AddListener(Skip);
        Auto_mover.onClick.AddListener(Auto);
        Pomoc.onClick.AddListener(Pomoc_faq);

       
    }

    void Update()
    {
      
        if(gameObject.activeSelf){
            ManagerForSecondProject.BlockForCutscene =  true;
        }
       
        DIALOG_HOLDER();
        DIALOG_EFFECTS();
        if(gameObject.activeSelf && !PANEL_POMOCY.activeSelf){
if((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) && ManagerForSecondProject.DM == false && TUTORIAL_BLOCKER == false ){
            NR_DIALOGU++;
        }
        }
    
            

    }

    void DIALOG_HOLDER(){   //Tu trzymam wszystkie mozliwe dialogi w grze, w sumie to mogłem to lepiej zoptymalizować...
    switch(NR_DIALOGU){
        case 1:
        PANEL_GORNY.SetActive(false);
        TXT_autor.text = "KAMIL";
        TXT_dialog.text = "Co jest?";
        break;
        case 2:
        TXT_autor.text = "STEFAN";
        TXT_dialog.text = "Słuchaj, nie ma czasu, musisz nam pomóc!";
        break;
        case 3:
        TXT_autor.text = "KAMIL";
        TXT_dialog.text = "Ale co? Co się dzieje?";
        break;
        case 4:
         TXT_autor.text = "JERZY";
        TXT_dialog.text = "Niemcy robią zaraz najazd na <color=red>Hotel</color>, a my potrzebujemy dowódcy.";
        break;
        case 5:
        TXT_autor.text = "STEFAN";
        TXT_dialog.text = "Dokładnie, no i pomyśleliśmy ze się nadasz.";
        break;
        case 6:
        TXT_autor.text = "KAMIL";
        TXT_dialog.text = "Uhh, ale że ja? No nie wiem...";
        break;
        case 7: 
        TXT_autor.text = "STEFAN";
        TXT_dialog.text = "...";
        break;
        case 8: 
        TXT_autor.text = "JERZY";
        TXT_dialog.text = "...";
        break;
        case 9: 
        TXT_autor.text = "KAMIL";
        TXT_dialog.text = "...";
        break;
        case 10:
        TXT_autor.text = "KAMIL";
        TXT_dialog.text = "...No dobra, wchodzę w to.";
        break;
        case 11:
        TXT_autor.text = "JERZY";
        TXT_dialog.text = "No i fajnie! Wybacz że to tak nagle, ale sam wiesz, <color=red>OCZEKIWANA GODZINA</color> wybiła, no i <color=red>ODDZIAŁY AK</color> walczą, ale brakuje im dowódcy...";
        break;
        case 12:
        TXT_autor.text = "STEFAN";
        TXT_dialog.text = "Dobra, musimy iść na zaplecze apteki Kalinowa, czekają tam na nas.";
        break;
        case 13:
        FadeOut.SetTrigger("FadeItOut");
        
ManagerForSecondProject.INTRO = false;
        MAPA.SetActive(true);
        ManagerForSecondProject.TUTORIAL = true;
        NR_DIALOGU = 14;
        LVL0_DIALOG1 = false;
        LVL0_DIALOG2 = true;
        gameObject.SetActive(false);
        
        
        break;
     //tutorial dialog//
        case 14:
        HP_GO.SetActive(false);
        TIME_GO.SetActive(false);
        RESOURCES_GO.SetActive(false);
        ENEMYCOUNTER_GO.SetActive(false);
TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Witaj w samouczku dotyczącym rozgrywki!";
        break;
        case 15:
                PANEL_GORNY.SetActive(true);
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Zacznijmy od menu i znaczenia ikon w nim zawartych:";
        break;
        case 16:
        ENEMYCOUNTER_GO.SetActive(true);
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "To jest licznik wroga, pokazuje on ilość pokonanych przeciwników w stosunku do pozostałych";
        break;
        case 17:
        RESOURCES_GO.SetActive(true);
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "To są zasoby, potrzebujesz ich do stawiania jednostek, aby je zdobyć pokonujesz przeciwników";
        break;
        case 18:
        TIME_GO.SetActive(true);
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "To jest odliczanie do przybycia wroga";
        break;
        case 19:
        HP_GO.SetActive(true);
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "To jest pasek HP celu, którego masz za zadanie bronić, jeśli HP spadnie poniżej 0, przegrywasz";
        break;
        case 20:
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Na mapie można zauważyć też czerwony kwadrat, służy on jako oznaczenie spawnu przeciwnika";
        break;
        case 21:
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "To wszystko jeśli chodzi o podstawowe oznaczenia!";
        break;
        case 22:
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "No to przejdźmy teraz do praktycznej części gry:";
        break;
        case 23:
        TUTORIAL_BLOCKER = true;
        if(Input.GetKeyDown("e")){
            NR_DIALOGU++;
            TUTORIAL_BLOCKER = false;
        }
        Skip_text.GetComponent<Image>().color = new Color(0.7f, 0.7f, 0.7f);
        Auto_mover.GetComponent<Image>().color = new Color(0.7f, 0.7f, 0.7f);
        Skip_text.interactable = false;
        Auto_mover.interactable = false;
        if(GameObject.Find("Scroll View").GetComponent<RectTransform>().rect.width == 115.66f){
            NR_DIALOGU++;
            TUTORIAL_BLOCKER = false;
        }

        
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Otwórz panel kupowania (klawisz E) aby kontynuować...";
        break;
        case 24:
        Skip_text.GetComponent<Image>().color = new Color(1f, 1f, 1f);
        Auto_mover.GetComponent<Image>().color = new Color(1f, 1f, 1f);
        Skip_text.interactable = true;
        Auto_mover.interactable = true;
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Tutaj znajdziesz wszystkie sojusznicze jednostki które możesz w tej chwili kupić";
        break;
        case 25:
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Na ten moment jest tylko jedna, ale wraz z nowymi poziomami, będzie ich przybywać więcej!";
        break;
        case 26:
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Pod nimi jest informacja ile dokładnie zasobów potrzebujesz, by móc je kupić";
        break;
        case 27:
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "By je kupić, naciśnij na nie lewym przyciskiem myszki, i tym samym przyciskiem postaw gdzieś na trawie";
        break;
        case 28:
        TUTORIAL_BLOCKER = true;
        Skip_text.GetComponent<Image>().color = new Color(0.7f, 0.7f, 0.7f);
        Auto_mover.GetComponent<Image>().color = new Color(0.7f, 0.7f, 0.7f);
        Skip_text.interactable = false;
        Auto_mover.interactable = false;
        if(PJ >= 2){
            NR_DIALOGU++;
        }
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Postaw 2 jednostki aby kontynuować...";
        break;
        case 29:
        TUTORIAL_BLOCKER = false;
        Skip_text.GetComponent<Image>().color = new Color(1f, 1f, 1f);
        Auto_mover.GetComponent<Image>().color = new Color(1f, 1f, 1f);
        Skip_text.interactable = true;
        Auto_mover.interactable = true;
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Aby je usunąć z mapy, naciśnij na nich prawym przyciskiem myszki, zwróci ci to 100% wydanych zasobów";
        break;
        case 30:
       TUTORIAL_BLOCKER = true;
        Skip_text.GetComponent<Image>().color = new Color(0.7f, 0.7f, 0.7f);
        Auto_mover.GetComponent<Image>().color = new Color(0.7f, 0.7f, 0.7f);
        Skip_text.interactable = false;
        Auto_mover.interactable = false;       
if(PJ <= 0){
            NR_DIALOGU++;
        }
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Usuń 2 jednostki aby kontynuować...";
        break;
        case 31:
        TUTORIAL_BLOCKER = false;
        Skip_text.GetComponent<Image>().color = new Color(1f, 1f, 1f);
        Auto_mover.GetComponent<Image>().color = new Color(1f, 1f, 1f);
        Skip_text.interactable = true;
        Auto_mover.interactable = true;

        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Świetnie! pamiętaj też, że pod klawiszem <color=red>ESC</color> możesz wyjść z gry lub do ustawień!";
        break;
        case 32:
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "To wszystko z naszej strony, ale jeśli chcesz sobie coś przypomnieć z tego samouczka, to wystarczy że naciśniesz przycisk 'historia' nad dialogiem!";
        break;
        case 33:
        TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Miłej gry!";
        break;
        case 34:
        ManagerForSecondProject.TUTORIAL = false;
        LVL0_DIALOG2 = false;
        gameObject.SetActive(false);
        NR_DIALOGU++;
        break;
        case 35:
        LVL0_DIALOG3 = true;
                ManagerForSecondProject.BlockForCutscene = true;
        //MAPA.SetActive(false);
        //PANEL_GORNY.SetActive(false);
        TXT_autor.text = "KAMIL";
        TXT_dialog.text = "Udało się, odepchneliśmy ich!";
        break;

        case 36:
        TXT_autor.text = "ANTONI CHRUŚCIEL";
        TXT_dialog.text = "Gratuluje, akcja jak na medal!";
        ManagerForSecondProject.BlockForCutscene = false;
        break;

        case 37:
        TXT_autor.text = "KAMIL";
        TXT_dialog.text = "Huh? aa to Pan, Panie <color=red>Antoni Chruściel</color>! haha";
        break;


        case 38:
        TXT_autor.text = "ANTONI CHRUŚCIEL";
        TXT_dialog.text = "Teraz, jak <color=red>hotel Victoria</color> jest w naszych rękach, to może rozważcie fakt przeniesienia tu bazy?";
        break;

        case 39:

        TXT_autor.text = "ANTONI CHRUŚCIEL";
        TXT_dialog.text = "W końcu, jest to doskonały punkt strategiczny dla naszego oddziału";
        break;

        case 40:

        TXT_autor.text = "KAMIL";
        TXT_dialog.text = "...Naszego?";
        break;

        case 41:

        TXT_autor.text = "ANTONI CHRUŚCIEL";
        TXT_dialog.text = "No tak, pomyślałem sobie, że może zechcesz dołączyć do mojego batalionu 'Papiloty' Z warszawskiego <color=red>oddziału AK?</color>";
        break;
        case 42:

        TXT_autor.text = "KAMIL";
        TXT_dialog.text = "Hmm... no nie wiem";
        break;
        case 43:
        TXT_autor.text = "OLIWIER";
        TXT_dialog.text = "No dajesz Kamil! z twoimi umiejętnościami strategicznymi możesz zmienić oblicza powstania!";
        break;
        case 44:
        TXT_autor.text = "KAMIL";
        TXT_dialog.text = "Ugh, no moge spróbować ..chyba";
        break;
        case 45:
        TXT_autor.text = "ANTONI CHRUŚCIEL";
        TXT_dialog.text = "Uznaje więc propozycje za przyjętą, masz teraz do dyspozycji moje oddziały! Licze na ciebie";
        break;

        case 46:
        LVL0_DIALOG3 = false;
        ManagerForSecondProject.BlockForCutscene = true;
        WinPanel.SetActive(true);
        ManagerForSecondProject.Ending_Sequence = false;
        gameObject.SetActive(false);
        break;
        case 47:
        LVL1_DIALOG1 = true;
        TXT_autor.text = "OLIWIER";
        TXT_dialog.text = "Więc jaki jest nasz dalszy plan? W końcu masz dostęp do batalionu 'Papiloty";
        break;
        case 48:
        TXT_autor.text = "KAMIL";
        TXT_dialog.text = "Więc tak: przejrzałem zasoby batalionu, i jedno jest pewne... potrzebujemy więcej zasobów";
        break;
        case 49:
        TXT_autor.text = "KAMIL";
        TXT_dialog.text = "I tu fajna część, kojarzysz <color=red>gmach Prudential</color>, nie? Niemcy go przejeli, ale Polacy zamierzają go dziś odbić!";
        break;
        case 50:
        TXT_autor.text = "KAMIL";
        TXT_dialog.text = "No i przesiaduje tam obecnie ten ich generał, <color=red>Max Dirske</color>, jeśli pomożemy tamtym Polakom, to dostaniemy okazje by go porwać, przepytać...";
        break;
        case 51:
        TXT_autor.text = "KAMIL";
        TXT_dialog.text = "I ukraść im zasoby!";
        break;
        case 52:
         TXT_autor.text = "OLIWIER";
        TXT_dialog.text = "hmm brzmi jak dobry plan";
        break;
        case 53:
        LVL1_DIALOG1 = false;
             ManagerForSecondProject.BlockForCutscene = false;
         gameObject.SetActive(false);
        NR_DIALOGU++;
        break;
        case 54:
        LVL1_DIALOG2 = true;
                ManagerForSecondProject.BlockForCutscene = true;
        TXT_autor.text = "KAMIL";
        TXT_dialog.text = "Dobra! misja udana! to teraz tylko sie przygotować na przesłuchanie...";
        break;
        case 55:
        LVL1_DIALOG2 = false;
         WinPanel.SetActive(true);
          NR_DIALOGU++;
              gameObject.SetActive(false);
        break;
        case 56:
        LVL2_DIALOG1 = true;
                ManagerForSecondProject.BlockForCutscene = true;
        TXT_autor.text = "KAMIL";
        TXT_dialog.text = "Kto tu umie Niemiecki!?";
        break;
        case 57:
         TXT_autor.text = "Żołnierz batalionu";
        TXT_dialog.text = "Ja! jestem tłumaczem";
        break;
        case 58:
         TXT_autor.text = "KAMIL";
        TXT_dialog.text = "Potrzebujemy cie do przepytania tego niemieckiego generała, chodź z nami";
        break;
        case 59:
         TXT_autor.text = "Żołnierz batalionu";
        TXT_dialog.text = "Hallo Max, warum erzählst du mir nicht von deinen Plänen? <color=black>(Cześć Max, może powiesz mi o swoich planach?)</color>";
        break;
         case 60:
         TXT_autor.text = "Max";
        TXT_dialog.text = "Ich werde es dir nicht sagen, polnisches Schwein. Im Allgemeinen spreche ich Polnisch, daher weiß ich nicht, warum wir Deutsch sprechen <color=black>(Nie powiem ci, polska świnio. Generalnie mówię po polsku, więc nie wiem, dlaczego mówimy po niemiecku)</color>";
        break;
        case 61:
         TXT_autor.text = "Żołnierz batalionu";
        TXT_dialog.text = " Ułatwisz mi tylko sprawę w aktach skoro tak, jakie macie plany na atak? Może się podzielisz?";
        break;
        case 62:
         TXT_autor.text = "Max";
        TXT_dialog.text = "Gówno ci powiem!";
        break;
         case 63:
         TXT_autor.text = "Żołnierz batalionu";
        TXT_dialog.text = "No cóż, skoro tak";
        break;
         case 64:
         TXT_autor.text = "Żołnierz batalionu";
        TXT_dialog.text = "*Strzela Max'owi w kolano*";
        break;
         case 65:
         TXT_autor.text = "Max";
        TXT_dialog.text = "AGH!!! DOBRA JUŻ DOBRA, POCZTA POLSKA, NASTĘPNY CEL TO <color=red>POCZTA POLSKA</color>";
        break;
         case 66:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Dobra... czyli trzeba lepiej ich o tym powiadomić, dobra robota żołnierzu!";
        break;
         case 67:
         TXT_autor.text = "Żołnierz Batalionu";
        TXT_dialog.text = "Prościzna! co z nim dalej zrobimy?";
        break;
        case 68:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Cóż, mysle że wia....";
        break;
        case 69:
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "Chłopaki!!! Niemcy sie chyba lekko wkurzyli że porwaliśmy Maxa, idzie na nas cała armia, pomóżcie nam, szybko!";
        break;
        case 70:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "To było do przewidzenia... Ruszajmy!";
        break;
         case 71:
         LVL2_DIALOG1 = false;
             ManagerForSecondProject.BlockForCutscene = false;
         gameObject.SetActive(false);
        NR_DIALOGU++;
        break;
        case 72:
        LVL2_DIALOG2 = true;
        ManagerForSecondProject.BlockForCutscene = true;
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Niemcy odparci! Wszyscy cali!?";
        break;
        case 73:
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "O nas sie nie martw, daliśmy rade, gorzej, że <color=red>Max</color> dał rade uciec...";
        break;
         case 74:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "To nie jest nic dobrego, choć z drugiej strony, pokazaliśmy im że sobie nie żartujemy, i jesteśmy silni";
        break;
         case 75:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Może poczekajmy aż sytuacja się rozwinie, dajmy sobie z nim spokój na razie";
        break;

        case 76:
        LVL2_DIALOG2 = false;
         WinPanel.SetActive(true);
          NR_DIALOGU++;
              gameObject.SetActive(false);
        break;
        
          case 77:
          LVL3_DIALOG1 = true;
         TXT_autor.text = "Heinrich Himmler";
        TXT_dialog.text = " *Z radia* Każdego trzeba zabić i nie wolno brać jeńców. Warszawa ma być zrównana jako sposób zastraszenia całej Europy";
        break;
        case 78:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "... Trzeba wszystkich o tym powiadomić, powinniśmy spodziewać się więcej ataków...";
        break;
         case 79:
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "No tak... przy okazji, pare godzin temu odwiedził nas <color=red>Henryk Leliwa-Roycewicz</color>, kojarzysz go, nie?";
        break;
         case 80:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "No oczywiście że tak, jest dowódcą <color=red>'Godziny W'</color> czyli jego Armii złożonej z listonoszy! Co chciał?";
        break;
         case 81:
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "Proponował współprace, my pomagamy mu w obronie <color=red>poczty</color>, a on wzamian da nam pare jednostek do pomocy";
        break;
         case 82:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Brzmi jak dobry układ, lepiej kierujmy się do niego, <color=red>Himmler</color> raczej nie żartował...";
        break;
        //TUTORIAL2//////////////////////
        case 83:
        FadeOut.SetTrigger("FadeItOut");
        ManagerForSecondProject.TUTORIAL = true;
        LVL3_DIALOG1 = false;
        LVL3_DIALOGT = true;
        NR_DIALOGU = 84;
        break;
        case 84:
         TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Witaj spowrotem! wkroczyłeś właśnie do poziomu 3! Mamy nadzieje że gra sie podoba?";
        break;
        case 85:
        TUTORIAL_BLOCKER = true;
        if(Input.GetKeyDown("e")){
            NR_DIALOGU++;
            TUTORIAL_BLOCKER = false;
        }
        Skip_text.GetComponent<Image>().color = new Color(0.7f, 0.7f, 0.7f);
        Auto_mover.GetComponent<Image>().color = new Color(0.7f, 0.7f, 0.7f);
        Skip_text.interactable = false;
        Auto_mover.interactable = false;
        if(GameObject.Find("Scroll View").GetComponent<RectTransform>().rect.width == 115.66f){
            NR_DIALOGU++;
            TUTORIAL_BLOCKER = false;
        }
         TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "W tym poziomie, możesz zauważyć jedną nową rzecz (Naciśnij E aby kontynuuować)";
        break;
         case 86:
         TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Mianowicie, pojawiły się na mapie 'Bonusowe Pola' które sprawiają że gdy postawisz tam jakąkolwiek jednostke, dostaje ona wzmocnienie określonej cechy";
        break;
        case 87:
         TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Są tylko 3 rodzaje takich pól, wszystkie widzisz na mapie, a odróżnia się je tak:";
        break;
        case 88:
         TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "<color=red>ZIELONE POLE</color> dodaje jednostce umiejscowionej na tym polu 40 HP więcej";
        break;
        case 89:
         TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "<color=red>ŻÓŁTE POLE</color> dodaje jednostce umiejscowionej na tym polu 15 zasobów więcej z pokonanej wrogiej jednostki";
        break;
        case 90:
         TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "<color=red>CZERWONE POLE</color> dodaje jednostce umiejscowionej na tym polu 20 punktów do zadawanych obrażeń";
        break;
        case 91:
         TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Widzimy się ostatni raz, ale pamiętaj że zawsze możesz przeczytać wszystko od nowa pod przyciskiem 'Historia' w oknie dialogowym";
        break;
        case 92:
         TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "To wszystko!";
        break;
        case 93:
         TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Powodzenia i miłej gry!";
        break;
        //END OF TUTORIAL2/////////////////
        case 94:
        ManagerForSecondProject.TUTORIAL = false;
        LVL3_DIALOGT = false;
             ManagerForSecondProject.BlockForCutscene = false;
         gameObject.SetActive(false);
        NR_DIALOGU++;
        break;
        case 95:
        LVL3_DIALOG2 = true;
        ManagerForSecondProject.BlockForCutscene = true;
         TXT_autor.text = "Max";
        TXT_dialog.text = "Udało się! obroniliśmy <color=red>Poczte Polską!</color>";
        break;
        case 96:
        LVL3_DIALOG2 = false;
         WinPanel.SetActive(true);
          NR_DIALOGU++;
              gameObject.SetActive(false);
        break;
        
        case 97:
        LVL4_DIALOG1 = true;
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "Podsłuchałem radio wroga, idą właśnie na <color=red>Polską Wytwórnie Papierów Wartościowych</color>";
        break;
         case 98:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Nie jest dobrze, coraz więcej tych Niemców...";
        break;
         case 99:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Powiadom o tym ludzi, musimy dać z siebie wszystko przy obronie <color=red>wytwórni!</color>";
        break;
         case 100:
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "Jasne!";
        break;
         case 101:
         LVL4_DIALOG1 = false;
             ManagerForSecondProject.BlockForCutscene = false;
         gameObject.SetActive(false);
        NR_DIALOGU++;
        break;
        case 102:
        LVL4_DIALOG2 = true;
        ManagerForSecondProject.BlockForCutscene = true;
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "Strasznie ciężka ta armia... ledwo daliśmy rade";
        break;
         case 103:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "No, ale liczy się, że wygraliśmy. Świetna robota!";
        break;
        case 104:
        LVL4_DIALOG2 = false;
         WinPanel.SetActive(true);
          NR_DIALOGU++;
              gameObject.SetActive(false);
        break;
        case 105:
        LVL5_DIALOG1 = true;
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "Ugh... dzień w dzień jakieś ataki, dali by sobie spokój...";
        break;
         case 106:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Cóż, tak już bywa na wojnie, przy okazji, dostałem właśnie informacje, jakoby rodzina Krasińskich była w tarapatach, prosili nas o pomoc w obronie ich <color=red>pałacu</color>";
        break;
        case 107:
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "Dobra, to zbiore oddział i widzimy się tam za pół godziny";
        break;
         case 108:
         LVL5_DIALOG1 = false;
             ManagerForSecondProject.BlockForCutscene = false;
         gameObject.SetActive(false);
        NR_DIALOGU++;
        break;
        case 109:
        LVL5_DIALOG2 = true;
        ManagerForSecondProject.BlockForCutscene = true;
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "Uff, to chyba już wszyscy, Świetna robota!";
        break;
         case 110:
         LVL5_DIALOG2 = false;
         WinPanel.SetActive(true);
          NR_DIALOGU++;
              gameObject.SetActive(false);
        break;
         case 111:
         LVL6_DIALOG1 = true;
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Oliwier! zrobiło się poważnie, dostałem informacje że wróg kieruje się na <color=red>bank PKO</color>";
        break;
          case 112:
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "Kurde, powinniśmy się śpieszyć tam z pomocą obrony, dopuszczenie wroga do masy złota i pieniędzy może źle się skończyć...";
        break;
         case 113:
         LVL6_DIALOG1 = false;
             ManagerForSecondProject.BlockForCutscene = false;
         gameObject.SetActive(false);
        NR_DIALOGU++;
        break;
         case 114:
         LVL6_DIALOG2 = true;
         ManagerForSecondProject.BlockForCutscene = true;
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "Hurra! sukces, odepchneliśmy Niemców";
        break;
        case 115:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "No i fajnie, wysłałem paru ludzi aby sprawdzili czy bank nie ucierpiał i nic z niego nie ukradziono, jak na razie wszystko się zgadza";
        break;
        case 116:
        LVL6_DIALOG2 = false;
         WinPanel.SetActive(true);
          NR_DIALOGU++;
              gameObject.SetActive(false);
        break;
        case 117:
        LVL7_DIALOG1 = true;
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Oliwier, zbieraj kogo się da, Polacy odbili <color=red>Gęsiówke<color>, ale sami nie dadzą rady, musimy im pomóc odepchnąć pozostałych Niemców";
        break;
        case 118:
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "Jasne!";
        break;
        case 119:
        LVL7_DIALOG1 = false;
             ManagerForSecondProject.BlockForCutscene = false;
         gameObject.SetActive(false);
        NR_DIALOGU++;
        break;
        case 120:
        LVL7_DIALOG2 = true;
         ManagerForSecondProject.BlockForCutscene = true;
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "O Boże, ile tu ciał, i to nie tylko wroga...";
        break;
        case 121:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Co nie? prawdziwy koszmar... niestety wszystkich uratować się nigdy nie da...";
        break;
         case 122:
         LVL7_DIALOG2 = false;
         WinPanel.SetActive(true);
          NR_DIALOGU++;
              gameObject.SetActive(false);
        break;
        case 123:
        LVL8_DIALOG1 = true;
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Właśnie dostałem informacje od jednego z uczniów <color=red>Politechniki Warszawskiej</color>, że ich szkoła zaczęła obrywać, powinniśmy iść im pomóc ";
        break;
        case 124:
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "Ani chwili odpoczynku, huh? ruszajmy!";
        break;
        case 125:
        LVL8_DIALOG1 = false;
             ManagerForSecondProject.BlockForCutscene = false;
         gameObject.SetActive(false);
        NR_DIALOGU++;
        break;
        case 126:
        LVL8_DIALOG2 = true;
         ManagerForSecondProject.BlockForCutscene = true;
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "O kurcze, udało się! To była największa bitwa w moim życiu...";
        break;
         case 127:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Miejmy nadzieje że już po wszystkim, nie? Oliwier?";
        break;
        case 128:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Huh? A gdzie on sie podział? Hej żołnierzu! Widziałeś gdzieś Oliwiera?";
        break;
        case 129:
         TXT_autor.text = "Żołnierz Batalionu";
        TXT_dialog.text = "Tak, siedzi za tamtą rozwaloną ścianą z medykiem, z tego co widziałem jest ranny";
        break;
        case 130:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Co!? Musze tam szybko biec!";
        break;
        case 131:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Oliwier! wszystko w porządku?!";
        break;
        case 132:
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "T..Ta, to tylko lekkie draśnięcie";
        break;
        case 133:
         TXT_autor.text = "Oliwier";
        TXT_dialog.text = "Bardziej ważne jest *Kaszel* to co zabrałem jednemu Niemcowi... Sam zobacz";
        break;
        case 134:
         TXT_autor.text = "Zakrwawiony List";
        TXT_dialog.text = "Dranie z Batalionu papiloty są dla nas zagrożeniem, zbierz wszystkie jednostki jakie masz i natychmiast ruszaj na politechnike";
        break;
        case 135:
         TXT_autor.text = "Zakrwawiony List";
        TXT_dialog.text = "Inne jednostki dołączą do ciebie wkrótce, ruszamy tam pełną mocą, zbyt mocno już nas upokorzyli!";
        break;
        case 136:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Niech to... Czyli to nie koniec, musimy cie gdzieś przetransportować, tu jest niebezpiecznie";
        break;
        case 137:
         TXT_autor.text = "Medyk Batalionu";
        TXT_dialog.text = "Obawiam się, że nie będzie to konieczne, rana jest zbyt ciężka... I może on umrzeć w każdej chwili";
        break;
        case 138:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "...";
        break;
        case 139:
         TXT_autor.text = "Żołnierz Batalionu";
        TXT_dialog.text = "Hej wszyscy! Kolejna fala Niemców właśnie sie zbliża, przygotujcie sie bo to nie koniec!";
        break;
        case 140:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "Nosz nie w tym momencie, musimy cie stąd zabrać Oliwier, musi być jeszcze nadzieja";
        break;
        case 141:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "O-Oliwier?";
        break;
        case 142:
         TXT_autor.text = "Medyk Batalionu";
        TXT_dialog.text = "Chyba nadszedł już na niego czas...";
        break;
        case 143:
         TXT_autor.text = "Kamil";
        TXT_dialog.text = "...Twoje czyny dla Polski nie zostaną zapomniane Oliwier, już ja tym Niemcom pokaże!";
        break;
        case 144:
         TXT_autor.text = "FourWayGames";
        TXT_dialog.text = "Z racji iż pokonałeś wcześniej ogromną ilość Niemców, dostajesz 999 zasobów do każdych trzech typów! Pokaż im na co cie stać!";
        break;
        case 145:
        ManagerForSecondProject.RZ = 999;
        ManagerForSecondProject.AMM = 999;  //Wohoo!
        ManagerForSecondProject.MECH = 999;
         LVL8_DIALOG2 = false;
             ManagerForSecondProject.BlockForCutscene = false;
         gameObject.SetActive(false);
        //NR_DIALOGU++;
        break;
        // case 145:
         //WinPanel.SetActive(true);
         // NR_DIALOGU++;
           //   gameObject.SetActive(false);
        //break;
    

        
        case 161:
          ManagerForSecondProject.BlockForCutscene = false;
         gameObject.SetActive(false);
        NR_DIALOGU++;
        break;
        case 643:
         WinPanel.SetActive(true);
          NR_DIALOGU++;
              gameObject.SetActive(false);
        break;
        
    } 
       
    }

     void DIALOG_EFFECTS(){  //rzeczy takie jak kolor, animacja, zmiana jpg postaci etc etc etc
     if(WinPanel.activeSelf){
      ManagerForSecondProject.SoundTrack.Stop();
     }
                if(TXT_autor.text == "KAMIL"){
                    Aktor1.SetActive(true);
                    TXT_autor.color = Color.white;
                }else{
                    Aktor1.SetActive(false);
                }
                if(TXT_autor.text == "JERZY"){
                    TXT_autor.color = Color.red;
                }
                if(TXT_autor.text == "STEFAN"){
                    TXT_autor.color = Color.green;
                }
                 if(TXT_autor.text == "FourWayGames"){
                    TXT_autor.color = Color.blue;
                }
                if(TXT_autor.text == "ANTONI CHRUŚCIEL"){
                    TXT_autor.color = Color.gray;
                }
                if(TXT_autor.text == "STEFAN" || TXT_autor.text == "JERZY" || TXT_autor.text == "ANTONI CHRUŚCIEL"){
                    Aktor2.SetActive(true);
                 
                }else{
                    Aktor2.SetActive(false);
                }
    }
        
     void Skip(){
         if(!PANEL_POMOCY.activeSelf){
 if(LVL0_DIALOG1){
        NR_DIALOGU = 13; 
         }
         if(LVL0_DIALOG2){
              PANEL_GORNY.SetActive(true);
             TIME_GO.SetActive(true);
             RESOURCES_GO.SetActive(true);
             ENEMYCOUNTER_GO.SetActive(true);
             HP_GO.SetActive(true);
             NR_DIALOGU = 34;
         }
         if(ManagerForSecondProject.Ending_Sequence){
             NR_DIALOGU = 34;
         }
         if(LVL0_DIALOG3){
             NR_DIALOGU = 46;
         }
         if(LVL1_DIALOG1){
             NR_DIALOGU = 53;
         }
         if(LVL1_DIALOG2){
             NR_DIALOGU = 55;
         }
         if(LVL2_DIALOG1){
             NR_DIALOGU = 71;
         }
         if(LVL2_DIALOG2){
             NR_DIALOGU = 76;
         }
         if(LVL3_DIALOG1){
             NR_DIALOGU = 83;
         }
         if(LVL3_DIALOGT){
             NR_DIALOGU = 94;
         }
         if(LVL3_DIALOG2){
             NR_DIALOGU = 96;
         }
         if(LVL4_DIALOG1){
             NR_DIALOGU = 101;
         }
         if(LVL4_DIALOG2){
             NR_DIALOGU = 104;
         }
         if(LVL5_DIALOG1){
             NR_DIALOGU = 108;
         }
         if(LVL5_DIALOG2){
             NR_DIALOGU = 110;
         }
         if(LVL6_DIALOG1){
             NR_DIALOGU = 113;
         }
         if(LVL6_DIALOG2){
             NR_DIALOGU = 116;
         }
         if(LVL7_DIALOG1){
             NR_DIALOGU = 119;
         }
         if(LVL7_DIALOG2){
             NR_DIALOGU = 122;
         }
         if(LVL8_DIALOG1){
             NR_DIALOGU = 125;
         }
         if(LVL8_DIALOG2){
             NR_DIALOGU = 143;
         }
         }
        
    
     }   
     void Pomoc_faq(){
           if(!PANEL_POMOCY.activeSelf){
               Time.timeScale = 0;
               PANEL_POMOCY.SetActive(true);
           }else{
               Time.timeScale = 1;
               PANEL_POMOCY.SetActive(false);
           }
     }

     void Auto(){
         if(!PANEL_POMOCY.activeSelf){
if(Auto_mover.gameObject.transform.GetChild(0).transform.GetComponent<Text>().text == "auto"){
                     A = StartCoroutine(_AUTO());
          Auto_mover.gameObject.transform.GetChild(0).transform.GetComponent<Text>().text = "manual";
         }else{
             StopCoroutine(A);
          Auto_mover.gameObject.transform.GetChild(0).transform.GetComponent<Text>().text = "auto";
         }
         }
         
     }         
    
    IEnumerator _AUTO(){
        
        if(LVL0_DIALOG1){
            while(NR_DIALOGU != 13){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
        if(LVL0_DIALOG2){
            while(NR_DIALOGU != 34){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
          if(LVL0_DIALOG3){
            while(NR_DIALOGU != 46){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
          if(LVL1_DIALOG1){
            while(NR_DIALOGU != 53){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
          if(LVL1_DIALOG2){
            while(NR_DIALOGU != 55){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
         if(LVL2_DIALOG1){
            while(NR_DIALOGU != 71){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
          if(LVL2_DIALOG2){
            while(NR_DIALOGU != 76){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
         if(LVL3_DIALOG1){
            while(NR_DIALOGU != 83){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
        if(LVL3_DIALOGT){
            while(NR_DIALOGU != 94){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
          if(LVL3_DIALOG2){
            while(NR_DIALOGU != 96){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
         if(LVL4_DIALOG1){
            while(NR_DIALOGU != 101){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
          if(LVL4_DIALOG2){
            while(NR_DIALOGU != 104){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
         if(LVL5_DIALOG1){
            while(NR_DIALOGU != 108){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
          if(LVL5_DIALOG2){
            while(NR_DIALOGU != 110){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
         if(LVL6_DIALOG1){
            while(NR_DIALOGU != 113){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
          if(LVL6_DIALOG2){
            while(NR_DIALOGU != 116){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
         if(LVL7_DIALOG1){
            while(NR_DIALOGU != 119){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
          if(LVL7_DIALOG2){
            while(NR_DIALOGU != 122){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
         if(LVL8_DIALOG1){
            while(NR_DIALOGU != 125){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
          if(LVL8_DIALOG2){
            while(NR_DIALOGU != 143){
                yield return new WaitForSeconds(4);
                NR_DIALOGU++;
            }
        }
    }

    
}
