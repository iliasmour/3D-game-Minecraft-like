using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layerCheck : MonoBehaviour {
    private float prevPosition;
    private int K = initializeGame.N;
    private AudioSource audioSource;
    public AudioClip gameover;
    // Use this for initialization
    void Start () {
        prevPosition = transform.position.y;
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y > 0.001){
            if (transform.position.y < prevPosition - 0.37)
            {
                if (initializeGame.score - 5 <= 0)
                {
                    if (initializeGame.life - 1 == 0)
                    {
                        initializeGame.score = 0;
                        initializeGame.life = 0;
                        transform.position = new Vector3(K / 2, 2, K / 2);
                        Time.timeScale = 0;
                        audioSource.PlayOneShot(gameover);
                    }
                    initializeGame.score = 50;
                    initializeGame.life -= 1;
                }
                else
                {
                    initializeGame.score -= 5;
                }
                prevPosition = transform.position.y;
            }
        }
       
        if (Input.GetKeyDown(KeyCode.Space))
        {

            
            StartCoroutine(Example());

            if (transform.position.y > prevPosition){
            initializeGame.score += 5;
                    
            }
            prevPosition = transform.position.y;
            

        }


    }
    IEnumerator Example()
    {

        yield return new WaitForSeconds(3);

    }
}

