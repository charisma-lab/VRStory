using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roboCop_park : MonoBehaviour
{
    public Animator anim;   // ref to female villain's animator
    // public bool villainMoving = false;  // to prevent double taps
    // public GameObject theNote;
    // public GameObject theBackpack;
   /* public AudioSource robo_sound;*/
    public GameObject electricSpark;
    public AudioClip electricSparkSound;

    /*public AudioClip park21;
    public AudioClip park22;
    public AudioClip park23;
    public AudioClip park24;
    public AudioClip park25;
    public AudioClip park26;
    public AudioClip park27;
*/
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        //robo_sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Debug.Log("Give Bag");
            anim.Play("roboCop_searchingMore");
        }
        if (Input.GetKeyDown("3"))
        {
            Debug.Log("Give Bag");
            anim.Play("roboCop_searchingP2");
        }
        if (Input.GetKeyDown("4"))
        {
            Debug.Log("roboCop Fountain");
            anim.Play("roboCop_fountain");
        }
        if (Input.GetKeyDown("6"))
        {
            Debug.Log("roboCop Final");
            anim.Play("roboCop_final");

        }
    }

    public void electricSparkEffectOn()
    {
        electricSpark.SetActive(true);
        //roboSound.PlayOneShot(electricSparkSound);
    }

    public void electricSparkEffectOff()
    {
        electricSpark.SetActive(false);
    }
    /*
    void park_21()
    {
        robo_sound.PlayOneShot(park21);
    }
    void park_22()
    {
        robo_sound.PlayOneShot(park22);
    }
    void park_23()
    {
        robo_sound.PlayOneShot(park23);
    }
    void park_24()
    {
        robo_sound.PlayOneShot(park24);
    }
    void park_25()
    {
        robo_sound.PlayOneShot(park25);
    }
    void park_26()
    {
        robo_sound.PlayOneShot(park26);
    }
    void park_27()
    {
        robo_sound.PlayOneShot(park27);
    }*/
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
