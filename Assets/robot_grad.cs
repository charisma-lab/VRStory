using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot_grad : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
   

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Debug.Log("RobotComeIn");
            anim.SetBool("RobotComeIn", true);
        }

        if (Input.GetKeyDown("4"))
        {
            Debug.Log("robotMove1");
            anim.SetBool("robotMove1", true);
        }

        if (Input.GetKeyDown("5"))
        {
            Debug.Log("robotMove2");
            anim.SetBool("robotMove2", true);
        }
        if (Input.GetKeyDown("6"))
        {
            Debug.Log("robotRunAway");
            anim.SetBool("robotRunAway", true);
        }
    }
}
