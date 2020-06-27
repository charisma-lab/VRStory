using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class female_villain_controller : MonoBehaviour
{
    public Animator anim;   // ref to female villain's animator
    public bool villainMoving = false;  // to prevent double taps
    public GameObject theBackpack;
    public GameObject theCap;      // ref to the cap
    public GameObject friend;     // ref to the friend
    public GameObject teacher;     // ref to the teacher

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("v") && !villainMoving)
        {
            Debug.Log("Villain triggered!");
            villainMoving = true;
            anim.Play("villain_classroom_turning");
            // also get the villain's friend to stop talking and being idle
            friend.GetComponent<Animator>().Play("friend_turns_away");
        }

        if (Input.GetKeyDown("l") && villainMoving)
        {
            anim.Play("villain_classroom_leaving_with_cap");
        }
    }

    // Function called when teacher should sit down
    void teacherSit()
    {
        teacher.GetComponent<Animator>().Play("BasicMotions@SitMed01 - Start");
    }
    
    // Function called when villain has moved out of the room
    void villainLeft()
    {
        villainMoving = false;
    }

    //Deactivate Backpack
    void hideBackpack()
    {
        theBackpack.SetActive(false);
    }

    //Deactivate Cap
    void hideCap()
    {
        theCap.SetActive(false);
    }
}
