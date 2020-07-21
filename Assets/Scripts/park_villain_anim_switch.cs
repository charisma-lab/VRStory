using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class park_villain_anim_switch : MonoBehaviour
{
    public Animator anim;   // ref to female villain's animator
    // public bool villainMoving = false;  // to prevent double taps
    // public GameObject theNote;
    // public GameObject theBackpack;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Debug.Log("Villain reveals themselves!");
            anim.Play("park_villain_reveal");
        }

        if (Input.GetKeyDown("2"))
        {
            Debug.Log("Tree anim");
            anim.Play("park_villain_tree");
        }

        if (Input.GetKeyDown("3"))
        {
            Debug.Log("villain lures the user away!");
            anim.Play("park_villain_lure");
        }

        if (Input.GetKeyDown("5"))
        {
            Debug.Log("villain leaving");
            anim.Play("park_villain_leaves");
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
