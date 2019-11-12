using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createCubes : MonoBehaviour
{
    public float range = 10F;
    public GameObject BlueCube;
    public GameObject YellowCube;
    public GameObject RedCube;
    public GameObject GreenCube;
    public LayerMask ignoremask;
    public AudioClip createCube;
    private Camera fpsCam;
    private AudioSource audioSource;
    private int color = 5;
    


    void Start()
    {
        fpsCam = GetComponent<Camera>();
        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {



        if (Input.GetMouseButtonDown(0))
        {
            if (initializeGame.reserve > 0)
            {
                
                initializeGame.score += 5;
                initializeGame.reserve -= 1;
                RaycastHit hit;
                Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));

                if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, range, ignoremask))
                {

                    Vector3 Position = hit.transform.GetComponent<Transform>().position;


                    audioSource.PlayOneShot(createCube);
                    color = Random.Range(1, 5);
                    if (color == 1)
                    {

                        Instantiate(RedCube, new Vector3(Position.x, Position.y + 1, Position.z), Quaternion.identity);
                    }
                    else if (color == 2)
                    {
                        Instantiate(GreenCube, new Vector3(Position.x, Position.y + 1, Position.z), Quaternion.identity);
                    }
                    else if (color == 3)
                    {
                        Instantiate(BlueCube, new Vector3(Position.x, Position.y + 1, Position.z), Quaternion.identity);
                    }
                    else if (color == 4)
                    {
                        Instantiate(YellowCube, new Vector3(Position.x, Position.y + 1, Position.z), Quaternion.identity);
                    }

                }

            }
        }
    }
}