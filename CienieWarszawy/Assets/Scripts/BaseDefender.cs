using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDefender : MonoBehaviour
{ 
    [SerializeField] private float cooldown = 5f;
    private float cooldownTimer;
    public static bool EnemySpotted;
    private AudioSource GunSounds;
    void Start()
    {
        GunSounds = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        
        if(EnemySpotted){
           
            Invoke("Attackv2", 0f);
        }
    }

    void Attackv2(){
      cooldownTimer -= Time.deltaTime;
      Vector3 PSP = new Vector3(transform.position.x, transform.position.y - 0.7f, transform.position.z);
    if(cooldownTimer > 0) return;
    cooldownTimer = cooldown;
    GunSounds.Play();
      var P = Instantiate(Resources.Load("Projectile"), transform.position + (transform.right*1), transform.rotation) as GameObject;
      P.transform.SetParent(transform);
                     P.GetComponent<Rigidbody2D>().velocity = transform.right * 10;
                    Destroy(P, 1);
                     
    }
}
