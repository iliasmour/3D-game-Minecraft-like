using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kickCubes : MonoBehaviour {

    public float range = 10F;
    public GameObject BlueCube;
    public GameObject YellowCube;
    public GameObject RedCube;
    public GameObject GreenCube;
    public LayerMask ignoremask;
    public AudioClip kick;
    private AudioSource audioSource;
    private Camera fpsCam;
    private int N = initializeGame.N;
    

    void Start()
    {
        fpsCam = GetComponent<Camera>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {           
            RaycastHit hit;
            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, range, ignoremask))
            {
                Vector3 Position = hit.transform.GetComponent<Transform>().position;
                Vector3 PlayerPosition = fpsCam.transform.GetComponent<Transform>().position;

                if ((Position.x - PlayerPosition.x > -0.9) && (Position.x - PlayerPosition.x < 0) && (Position.z > PlayerPosition.z))
                {
                    Position.z = Position.z + 1;
                }
                if ((Position.x - PlayerPosition.x > -0.9) && (Position.x - PlayerPosition.x < 0) && (Position.z < PlayerPosition.z))
                {
                    Position.z = Position.z - 1;
                }
                if ((Position.z - PlayerPosition.z > -0.9) && (Position.z - PlayerPosition.z < 0) && (Position.x > PlayerPosition.x))
                {
                    Position.x = Position.x + 1;
                }
                if ((Position.z - PlayerPosition.z > -0.9) && (Position.z - PlayerPosition.z < 0) && (Position.x < PlayerPosition.x))
                {
                    Position.x = Position.x - 1;
                }


                if (!((Position.x < 0 && Position.z > 0) || (Position.x > 0 && Position.z < 0) || Position.x > N || Position.z > N)) {

                    if (hit.collider.tag == "Yellow")
                    {
                        audioSource.PlayOneShot(kick);

                        hit.collider.gameObject.transform.position = new Vector3(Position.x, Position.y, Position.z);

                    }
                    if (hit.collider.tag == "Blue")
                    {
                        audioSource.PlayOneShot(kick);
                        hit.collider.gameObject.transform.position = new Vector3(Position.x, Position.y, Position.z);

                    }
                    if (hit.collider.tag == "Red")
                    {
                        audioSource.PlayOneShot(kick);
                        hit.collider.gameObject.transform.position = new Vector3(Position.x, Position.y, Position.z);
                    }
                    if (hit.collider.tag == "Green")
                    {
                        audioSource.PlayOneShot(kick);
                        hit.collider.gameObject.transform.position = new Vector3(Position.x, Position.y, Position.z);
                    }
                }
                else {Destroy(hit.collider.gameObject);}

            }
        }
    }
}
