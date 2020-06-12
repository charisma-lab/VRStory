using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot_classroom : MonoBehaviour
{
    public Animator anim;   // ref to robot's animator
    public UnityEngine.Renderer robotButtonRenderer;   // ref to robot's renderer
    public AudioClip r11;
    public AudioClip r12;
    public AudioClip r13;
    public AudioSource robot_voice;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        // access the robot's wholebutton's button's renderer to be able to change the color of the button (parent child heirarchy)
        robotButtonRenderer = gameObject.transform.Find("WholeButton").transform.Find("Button").GetComponent<Renderer>();
        // ref to robot's audio source
        robot_voice = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Debug.Log("Robot triggered!");
            anim.Play("robot_classroom_enter");
        }
        if (Input.GetKeyDown("t"))
        {
            Debug.Log("Robot triggered!");
            anim.Play("robot_classroom_spin_lightup");
        }
    }

    // Function to change color of button when spinning, called by the animation
    void robotButtonLightup()
    {
        // get current color of button as an RGBA value
        Debug.Log(robotButtonRenderer.material.GetColor("_Color"));
        // change button shader from Bush bark to Green
        robotButtonRenderer.material.SetColor("_Color", Color.green);
        //cubeRenderer.material.SetColor("_Color", Color.red);
    }

    // Robot's Dialogue functions, called from the animations
    void robot11()
    {
        // robot_voice.PlayOneShot(r11); // Commenting out for voiceover
    }
    void robot12()
    {
        // robot_voice.PlayOneShot(r12); // Commenting out for voiceover
    }
    void robot13()
    {
        // robot_voice.PlayOneShot(r13); // Commenting out for voiceover
    }
}
