using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallCheck : MonoBehaviour {
    private int K = initializeGame.N;
    public AudioClip fall;
    private AudioSource audioSource;
    public AudioClip gameover;

    void Start()
    {  
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
  
        if (other.tag == "Player")
        {
            other.transform.position = new Vector3(K / 2, 1.5f, K / 2);
            if(initializeGame.life - 1 == 0)
            {
                initializeGame.score = 0;
                Time.timeScale = 0;
                audioSource.PlayOneShot(gameover);
            }
            else { audioSource.PlayOneShot(fall); }
            initializeGame.life -= 1;
            initializeGame.score = 50;
        }
    }
}
