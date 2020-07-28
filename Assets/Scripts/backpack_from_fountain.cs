using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backpack_from_fountain : MonoBehaviour
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
        if (Input.GetKeyDown("4"))
        {
            Debug.Log("roboCop Final");
            anim.Play("backpack_present");
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
