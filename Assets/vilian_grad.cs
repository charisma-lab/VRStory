using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vilian_grad : MonoBehaviour
{
    public Animator anim;
    public AudioSource shopkeeper_voice;
    public AudioClip Voice;
    //public AudioClip shopkeeper_Clip;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

// Update is called once per frame
void Update()
    {
        if (Input.GetKeyDown("2"))
        {
            Debug.Log("UserCome");
            anim.SetBool("UserCome", true);
        }
        if (Input.GetKeyDown("3"))
        {
            Debug.Log("VillianSpeak");
            anim.SetBool("VillianSpeak", true);
        }
    }
}
