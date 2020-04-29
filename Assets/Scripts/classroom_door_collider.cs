using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classroom_door_collider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Animator anim = GetComponent<Animator>();
        anim.Play("door_opening");
        Debug.Log("I have entered");
    }

    void OnTriggerExit(Collider other)
    {
        Animator anim = GetComponent<Animator>();
        anim.Play("door_closing");
        Debug.Log("I have left");
    }
}
