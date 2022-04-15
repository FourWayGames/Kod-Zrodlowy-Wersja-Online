using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_CONTROLLER : MonoBehaviour
{
    private Transform target;
    private int WavePointIndex = 0;
    public static int Liczba_WP, Liczba_WP2, Liczba_WP3;
    public GameObject OBJ_HP, sh_part;
    private bool StopNshoot, ShootTheBase;
    public bool AtkBoost, MoneyBoost, HPBoost;
    public float Speed;
    private GameObject bul;
     Collider2D[] hitColliders;
    [SerializeField] private float cooldown = 5f;
private float cooldownTimer;
private AudioSource GunSounds;
    
    void Start()
    {
       GunSounds = GetComponent<AudioSource>();
        //bul = GameObject.FindWithTag("MB");
        
 
      
        if(gameObject.tag == "Player"){
        Physics2D.IgnoreLayerCollision(3, 0, true);
        }
          
       if(gameObject.transform.parent.name == "spawner"){
         target = WP.points[0];
        }
        if((gameObject.transform.parent.name == "spawner (1)")){
          target = WP2.points[0];
        }
        if((gameObject.transform.parent.name == "spawner (2)")){
          target = WP3.points[0];
        }
        if(target == null){
          target = WP.points[0];
        }

        gameObject.transform.parent.GetComponent<Canvas>().sortingOrder = 1; //Fix na szybko żeby pasek HP sie przebił przez budynki i bonusowe pola
      
    }

    void Update()
    {       
      
      switch(gameObject.name){
        case "GER_NORMALSOL":
   hitColliders = Physics2D.OverlapCircleAll(gameObject.transform.position, 1.13f); 
  break;
  case "GER_SZTURMSOL":
   hitColliders = Physics2D.OverlapCircleAll(gameObject.transform.position, 1.5f); 
  break;
  case "GER_SNIPERSOL":
   hitColliders = Physics2D.OverlapCircleAll(gameObject.transform.position, 2f); 
  break;
  case "GER_TANKSOL":
   hitColliders = Physics2D.OverlapCircleAll(gameObject.transform.position, 1.35f); 
  break;
          case "PISTOLSOL_POL":
          hitColliders = Physics2D.OverlapCircleAll(gameObject.transform.position, 1.13f); 
          break;
          case "SZTURMSOL_POL":
          hitColliders = Physics2D.OverlapCircleAll(gameObject.transform.position, 1.5f); 
          break;
          case "SNIPERSOL_POL":
          hitColliders = Physics2D.OverlapCircleAll(gameObject.transform.position, 2.5f); 
          break;
          case "CZOLG_ENT_POL":
          hitColliders = Physics2D.OverlapCircleAll(gameObject.transform.position, 1.35f); 
          break;
      }
             
             
          if(gameObject.name != "MINA_ENT_POL"){
           Detect();
          }
          
if(Vector3.Distance(transform.position, target.position) <= 0.1f){
              GetNextWaypoint();
          }

      if(gameObject.tag == "enemy"){
  if(!StopNshoot){
    Vector3 dir = target.position - transform.position;
          transform.parent.Translate(dir.normalized * Speed * Time.deltaTime, Space.World);
   
        
          /* Vector3 difference = target.transform.position - transform.position;
 float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
 transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
          */
                           
    
 
          
        }
      }
     
     

          
    }

 /*void OnMouseEnter(){
    OBJ_HP.SetActive(true);
 } 
 void OnMouseExit(){
     OBJ_HP.SetActive(false);
 } */ 

private void OnDrawGizmos() { //do testów zasięgu
 Gizmos.color = Color.red;
  switch(gameObject.name){
    case "GER_NORMALSOL":
   Gizmos.DrawWireSphere(gameObject.transform.position, 1.13f);
  break;
  case "PISTOLSOL_POL":
   Gizmos.DrawWireSphere(gameObject.transform.position, 1.13f);
  break;
  case "SZTURMSOL_POL":
   Gizmos.DrawWireSphere(gameObject.transform.position, 1.5f);
  break;
  case "SNIPERSOL_POL":
   Gizmos.DrawWireSphere(gameObject.transform.position, 2.5f);
  break;
  case "CZOLG_ENT_POL":
   Gizmos.DrawWireSphere(gameObject.transform.position, 1.35f);
  break;
  

  }
     
    
 }

void Detect(){
     
 

        foreach (var hitCollider in hitColliders)
        {
          if(hitCollider.transform.tag == "enemy" && gameObject.transform.tag == "Player"){
            
   Vector3 difference = hitCollider.transform.position - transform.position;
 float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
 transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
                             Invoke("Attackv2", 0f);
          }else{
            
            if(gameObject.transform.tag == "enemy"){
               if(gameObject.transform.name == "Tank_GER(Clone)"){
              
            }else{
  Vector3 difference = target.transform.position - transform.position;
 float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
 transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
            }
            }
          
          }

          if(hitCollider.transform.tag == "Player" && gameObject.transform.tag == "enemy"){
        
   Vector3 difference = hitCollider.transform.position - transform.position;
 float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
 transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
                                                      Invoke("Attackv2", 0f);

                                      

          }

    
        

        }



         
      
         
      if(ShootTheBase){
        Invoke("Attackv2", 0f);
      } 
       
       
}
  
       
      
   
      

      
void OnTriggerEnter2D(Collider2D col){

  if(gameObject.transform.tag == "Player"){
      if(col.transform.tag == "HEALTH"){
          gameObject.GetComponent<HEALTH_SCRIPT>().Health += 50;
      }if(col.transform.tag == "DEFENSE"){
           AtkBoost = true;
      }if(col.transform.tag == "MONEY"){
        //do wypełnienia 
      }


  }

  if(gameObject.transform.tag == "enemy" && col.transform.tag == "MB"){
         ShootTheBase = true;
  }
        
      
}
  

    void GetNextWaypoint(){
        
         if((gameObject.transform.parent.name == "spawner")|| (gameObject.transform.parent.name == "Tankspawner")){
           if(WavePointIndex == Liczba_WP){
             if(gameObject.transform.GetChild(0).GetComponent<Animator>() != null){
                gameObject.transform.GetChild(0).GetComponent<Animator>().enabled = false;
             }
            
          StopNshoot = true;
           }
           if(WavePointIndex != Liczba_WP){
             WavePointIndex++;
               target = WP.points[WavePointIndex];
           }
           
         }
         if((gameObject.transform.parent.name == "spawner (1)")|| (gameObject.transform.parent.name == "Tankspawner (1)")){
            if(WavePointIndex == Liczba_WP2){
              if(gameObject.transform.GetChild(0).GetComponent<Animator>() != null){
             gameObject.transform.GetChild(0).GetComponent<Animator>().enabled = false;
              }
          StopNshoot = true;
           }
           if(WavePointIndex != Liczba_WP2){
             WavePointIndex++;
               target = WP2.points[WavePointIndex];
           }
           
         }
         if((gameObject.transform.parent.name == "spawner (2)")|| (gameObject.transform.parent.name == "Tankspawner (2)")){
            if(WavePointIndex == Liczba_WP3){
              if(gameObject.transform.GetChild(0).GetComponent<Animator>() != null){
             gameObject.transform.GetChild(0).GetComponent<Animator>().enabled = false;
              }
          StopNshoot = true;
           }
           if(WavePointIndex != Liczba_WP3){
             WavePointIndex++;
               target = WP3.points[WavePointIndex];
           }
           
         }
      
        
       
        
        
        
    }

    void Attackv2(){
      cooldownTimer -= Time.deltaTime;
      Vector3 PSP = new Vector3(transform.position.x, transform.position.y - 0.7f, transform.position.z);
    if(cooldownTimer > 0) return;
    cooldownTimer = cooldown;
    GunSounds.Play();
    StartCoroutine(ShootParticle());
      var P = Instantiate(Resources.Load("Projectile"), transform.position + (transform.right*1), transform.rotation) as GameObject;
      P.transform.SetParent(transform);
                     P.GetComponent<Rigidbody2D>().velocity = transform.right * 40;
                    Destroy(P, 1);
                     
    }

IEnumerator ShootParticle()
 {
       sh_part.SetActive(true);
     yield return new WaitForSeconds(0.3f);
     sh_part.SetActive(false);
     
 }
    
}
