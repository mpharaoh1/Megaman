using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class Auditrigger : MonoBehaviour
{
    AudioSource audiodata;
    // Start is called before the first frame update
    void Start()
    {
        audiodata = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audiodata.Play(0);

        }
        else
        {
            audiodata.Pause();
        }
    }
}
