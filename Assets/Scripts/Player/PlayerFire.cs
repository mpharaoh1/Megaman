using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(AudioSource))]
public class PlayerFire : MonoBehaviour
{
    AudioSource audioData;

    SpriteRenderer playerSprite;
    Animator anim;

    public Transform spawnPointLeft;
    public Transform spawnPointRight;

    public float projectileSpeed;
    public Projectile projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        
        

        playerSprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        if (projectileSpeed <= 0)
            projectileSpeed = 7.0f;

        if (!spawnPointLeft || !spawnPointRight || !projectilePrefab)
            Debug.Log("Unity Inspector Values Not Set");
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetButtonDown("Fire1"))
        {
            audioData.Play(0);
           
            anim.SetBool("isShooting", true);
        }
        
    }
    
    void FireProjectile()
    {
        if (playerSprite.flipX)
        {
            Projectile projectileInstance = Instantiate(projectilePrefab, spawnPointLeft.position, spawnPointLeft.rotation);
            projectileInstance.speed = -projectileSpeed;
        }
        else
        {
            Projectile projectileInstance = Instantiate(projectilePrefab, spawnPointRight.position, spawnPointRight.rotation);
            projectileInstance.speed = projectileSpeed;
        }

    }

    void ResetFire()
    {
        audioData.Pause();
        anim.SetBool("isShooting", false);
    }
}
