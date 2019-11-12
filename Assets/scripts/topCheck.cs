using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topCheck : MonoBehaviour {
    public AudioClip top;
    private AudioSource audioSource;

    void Start()
    {        
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audioSource.PlayOneShot(top);
            initializeGame.score += 100;
            initializeGame.life += 1;
            Debug.Log("top");
        }
    }
}
