using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class park_villain_anim_switch : MonoBehaviour
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
        if (Input.GetKeyDown("q"))
        {
            Debug.Log("Gazebo anim");
            anim.Play("park_anim_gazebo");
        }

        if (Input.GetKeyDown("e"))
        {
            Debug.Log("Tree anim");
            anim.Play("park_anim_tree");
        }

        if (Input.GetKeyDown("t"))
        {
            Debug.Log("run+throw");
            anim.Play("park_run_throw");
        }

        if (Input.GetKeyDown("u"))
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
