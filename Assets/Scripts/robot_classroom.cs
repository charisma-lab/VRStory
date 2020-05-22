using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot_classroom : MonoBehaviour
{
    public Animator anim;   // ref to robot's animator

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Debug.Log("Robot triggered!");
            anim.Play("robot_classroom_enter");
        }
    }
}
