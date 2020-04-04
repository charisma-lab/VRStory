using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator anim;
    public bool doorOpen = false;
    public AudioClip door_open;
    public AudioClip door_close;
    public AudioSource door_sound;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        door_sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("o") && !doorOpen)
        {
            anim.Play("door_opening");
            //door_sound.clip = door_open;
            //door_sound.Play();
            doorOpen = true;
        }
        if (Input.GetKeyDown("c") && doorOpen)
        {
            anim.Play("door_closing");
            //door_sound.clip = door_close;
            //door_sound.Play();
            doorOpen = false;
        }
    }

    // Sound functions for animation
    void doorOpenSound()
    {
        door_sound.PlayOneShot(door_open);
    }
    void doorCloseSound()
    {
        door_sound.PlayOneShot(door_close);
    }
}
