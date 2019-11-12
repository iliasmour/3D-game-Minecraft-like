using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCube : MonoBehaviour {

    
    public float range = 1F;
    private Camera fpsCam;
    private AudioSource audioSource;
    public GameObject BlueCube;
    public GameObject YellowCube;
    public GameObject RedCube;
    public GameObject GreenCube;
    public LayerMask ignoremask;
    public AudioClip changeColor;
    public AudioClip cantChange;
    public AudioClip gameover;
    void Start()
    {
        fpsCam = GetComponent<Camera>();
        audioSource = GetComponent<AudioSource>();
    }

	void Update () {
        
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (initializeGame.life > 0)
            {
                RaycastHit hit;
                Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
                if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, range, ignoremask))
                {
                    
                    if (hit.collider.tag == "Yellow") 
                    {
                        initializeGame.reserve += 1;
                        ChangeYellow(hit);

                    }
                    if (hit.collider.tag == "Blue")
                    {

                        Debug.Log("You can't change this cube!");
                        audioSource.PlayOneShot(cantChange);

                    }
                    if (hit.collider.tag == "Magenda")
                    {

                        Debug.Log("You can't change this cube!");
                        audioSource.PlayOneShot(cantChange);

                    }
                    if (hit.collider.tag == "Red")
                    {
                        initializeGame.reserve += 2;
                        ChangeRed(hit);
                    }
                    if (hit.collider.tag == "Green") 
                    {
                        initializeGame.reserve += 3;
                        ChangeGreen(hit);
                    }


                }
            }
        }
    }

    void ChangeYellow(RaycastHit hit)
    {
        
        initializeGame.score -= 5;
        
        if (initializeGame.score == 0 )
        {
            initializeGame.life -= 1;
            if (initializeGame.life != 0)
            {
                initializeGame.score = 50;
            }
            else
            {
                Time.timeScale = 0;
                audioSource.PlayOneShot(gameover);
            }
        }
        audioSource.PlayOneShot(changeColor);
        Vector3 Position = hit.transform.GetComponent<Transform>().position;
        Destroy(hit.collider.gameObject);
        Instantiate(BlueCube, Position, Quaternion.identity);
    }


    void ChangeGreen(RaycastHit hit)
    {
        initializeGame.score -= 5;
       
        if (initializeGame.score == 0)
        {
            initializeGame.life -= 1;
            if (initializeGame.life != 0)
            {
                initializeGame.score = 50;
            }
            else
            {
                Time.timeScale = 0;
                audioSource.PlayOneShot(gameover);
            }
        }
        audioSource.PlayOneShot(changeColor);
        Vector3 Position = hit.transform.GetComponent<Transform>().position;
        Destroy(hit.collider.gameObject);
        Instantiate(RedCube, Position, Quaternion.identity);
    }
    void ChangeRed(RaycastHit hit)
    {
        
        initializeGame.score -= 5;
        
        if (initializeGame.score == 0 )
        {
            initializeGame.life -= 1;
            if (initializeGame.life != 0)
            {
                initializeGame.score = 50;
            }
            else
            {
                Time.timeScale = 0;
                audioSource.PlayOneShot(gameover);
            }
        }
        audioSource.PlayOneShot(changeColor);
        Vector3 Position = hit.transform.GetComponent<Transform>().position;
        Destroy(hit.collider.gameObject);
        Instantiate(YellowCube, Position, Quaternion.identity);
    }
}
