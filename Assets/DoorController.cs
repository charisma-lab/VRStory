using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator anim;
    public bool doorOpen = false;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("o") && !doorOpen)
        {
            anim.Play("door_opening");
            doorOpen = true;
        }
        if (Input.GetKeyDown("c") && doorOpen)
        {
            anim.Play("door_closing");
            doorOpen = false;
        }
    }
}
