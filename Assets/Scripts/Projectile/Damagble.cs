using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource), typeof(SpriteRenderer))]
public class Damagble : MonoBehaviour
{
    AudioSource audioData;
    public float HP;
    float damage = 25;
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.CompareTag("bullet"))
        {
            HP -= damage;
            audioData.Play(0);
            Destroy(collison.gameObject);

        }
        else
        {
            audioData.Pause();

        }
         if ( HP == 0)
        {

            Destroy(gameObject);

        }
    }
   
}
