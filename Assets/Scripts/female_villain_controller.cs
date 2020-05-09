using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class female_villain_controller : MonoBehaviour
{
    public Animator anim;   // ref to female villain's animator
    public bool villainMoving = false;  // to prevent double taps

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
        }
    }

    // Function called when villain has moved out of the room
    void villainLeft()
    {
        villainMoving = false;
    }
}
