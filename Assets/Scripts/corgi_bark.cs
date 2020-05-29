using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corgi_bark : MonoBehaviour
{
    public Animator anim;   // ref to corgi's animator

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        doggo_sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            Debug.Log("Corgi Barked!");
            anim.Play("corgi_bark");
        }
    }

    // Play bark
    void park_27()
    {
        doggo_sound.PlayOneShot(park27);
    }

    /*
    // Function called when villain has moved out of the room
    void villainLeft()
    {
        villainMoving = false;
    }

    // Activate Note and 
    void showNote()
    {
        theNote.SetActive(true);
    }

    //Deactivate Backpack
    void hideBackpack()
    {
        theBackpack.SetActive(false);
    }
    */
}
