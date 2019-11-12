using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCubes : MonoBehaviour {
    public AudioClip destroy;
    public AudioClip cantChange;
    public float range = 1F;
    private AudioSource audioSource;
    private Camera fpsCam;  
    public LayerMask ignoremask;
    void Start()
    {
        fpsCam = GetComponent<Camera>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            RaycastHit hit;
         
            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, range, ignoremask))
            {
                if (hit.collider.tag == "Magenda")
                {

                    Debug.Log("You can't change this cube!");
                    audioSource.PlayOneShot(cantChange);

                }
                else
                {
                    audioSource.PlayOneShot(destroy);
                    Destroy(hit.collider.gameObject);
                }


            }
        }
    }
}
