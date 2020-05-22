using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roboCop_park : MonoBehaviour
{
    public Animator anim;   // ref to female villain's animator
    public bool villainMoving = false;  // to prevent double taps
    public GameObject theNote;
    public GameObject theBackpack;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Debug.Log("Give Bag");
            anim.Play("roboCop_giveBag");
        }

        if (Input.GetKeyDown("r"))
        {
            Debug.Log("Talk Later");
            anim.Play("roboCop_talkLater");
        }

        if (Input.GetKeyDown("y"))
        {
            Debug.Log("chase");
            anim.Play("roboCop_chase");
        }

        if (Input.GetKeyDown("i"))
        {
            Debug.Log("roboCop Fountain");
            anim.Play("roboCop_fountain");
        }
        if (Input.GetKeyDown("o"))
        {
            Debug.Log("roboCop Final");
            anim.Play("roboCop_final");
        }
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
