using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopkeeper : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public AudioSource shopkeeper_voice;
    public AudioClip Voice;
    //public AudioClip shopkeeper_Clip;

    void Start()
    {
        anim = GetComponent<Animator>();

        shopkeeper_voice = GetComponent<AudioSource>();
        anim.SetBool("UserCome", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Debug.Log("PlayerReachTheTable");
            anim.SetBool("UserCome", true);
        }

    }
    void playVoice()
    {
        shopkeeper_voice.PlayOneShot(Voice);
    }


}

