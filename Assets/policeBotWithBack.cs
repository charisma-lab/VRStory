using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class policeBotWithBack : MonoBehaviour
{
    public GameObject electricSpark;
    public GameObject smoke;
    public Animator anim;
    public AudioSource roboSound;
    public AudioClip electricSparkSound;
    
    void Start()
    {
        anim = GetComponent<Animator>();

        roboSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("2"))
        {
            Debug.Log("PoliceBotMoveIn");
            anim.SetBool("PoliceBotMoveIn", true);
        }

        if (Input.GetKeyDown("4"))
        {
            Debug.Log("PoliceBotToSurgery");
            anim.SetBool("ToSurgery", true);
        }

        if (Input.GetKeyDown("7"))
        {
            Debug.Log("FinishFixing");
            anim.SetBool("RobotFixingDone", true);
        }

    }
    void electricSparkEffectOn()
    {
        electricSpark.SetActive(true);
        roboSound.PlayOneShot(electricSparkSound);
    }

    void electricSparkEffectOff()
    {
        electricSpark.SetActive(false);
    }
}
