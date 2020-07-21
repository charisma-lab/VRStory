using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teacher_classroom : MonoBehaviour
{    
    public Animator anim;   // ref to teacher's animator
    public GameObject villain;     // ref to the villain

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("Teacher triggered!");
            anim.Play("BasicMotions@SitMed01 - End");
        }
        if (Input.GetKeyDown("t"))
        {
            Debug.Log("Teacher talking!");
            anim.Play("teacher_talks");
        }
    }
}
