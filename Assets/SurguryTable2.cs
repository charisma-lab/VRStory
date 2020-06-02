using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurguryTable2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public AudioSource machine_Sound;
    public AudioClip MachineUp;
    public AudioClip MachineDown;
    public AudioClip FixingMoving;
    public AudioClip Sparksound;

    public GameObject LeftSpark01;
    public GameObject LeftSpark02;
    public GameObject LeftSpark03;
    public GameObject LeftSpark04;

    public GameObject RightSpark;

    void Start()
    {
        anim = GetComponent<Animator>();

        machine_Sound = GetComponent<AudioSource>();
        //anim.SetBool("SurgeryTable", false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("3"))
        {
            Debug.Log("LowerTheSurguryTable");
            anim.SetBool("LowerTheTable", true);
            anim.SetBool("RaiseTheTable", false);
        }

        if (Input.GetKeyDown("0"))
        {
            Debug.Log("RaisingTheSurguryTable");
            anim.SetBool("RaiseTheTable", true);
            anim.SetBool("LowerTheTable", false);
        }

        if (Input.GetKeyDown("5"))
        {
            Debug.Log("FixingRobot");
            anim.SetBool("FixingRobot", true);
            anim.SetBool("FixingDone", false);
        }
        if (Input.GetKeyDown("6"))
        {
            Debug.Log("FixingDone");
            anim.SetBool("FixingDone", true);
            anim.SetBool("FixingRobot", false);
        }
    }

    void playMachineSoundDown()
    {
        machine_Sound.PlayOneShot(MachineDown);
    }
    void playMachineSoundUp()
    {
        machine_Sound.PlayOneShot(MachineUp);
    }
    void playFixingMoving()
    {
        machine_Sound.PlayOneShot(FixingMoving);
    }

    void LeftSpark01On()
    {
        LeftSpark04.SetActive(false);

        LeftSpark01.SetActive(true);
        machine_Sound.PlayOneShot(Sparksound);
    }

    void LeftSpark02On()
    {
        LeftSpark01.SetActive(false);

        LeftSpark02.SetActive(true);
        machine_Sound.PlayOneShot(Sparksound);
    }
    void LeftSpark03On()
    {
        LeftSpark02.SetActive(false);

        LeftSpark03.SetActive(true);
        machine_Sound.PlayOneShot(Sparksound);
    }
    void LeftSpark04On()
    {
        LeftSpark03.SetActive(false);

        LeftSpark04.SetActive(true);
        machine_Sound.PlayOneShot(Sparksound);
    }
    void LeftSparkOff()
    {
        LeftSpark02.SetActive(false);
    }
}
