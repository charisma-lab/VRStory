using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    public SerialPort sp = new SerialPort("COM3", 9600);
    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1000;

    }

    // Update is called once per frame
    void Update()
    {
        if (sp.IsOpen)
        {
            string move = sp.ReadLine();
            if (move == "1")
            {
                transform.localScale = new Vector3(0, 0, 0);
              //  transform.Translate(1, 0, 0);
                print(1);
            }
            else if (move == "0")
            {
                transform.localScale = new Vector3(1, 1, 1);
                //transform.Translate(0, 0, 0);
                print(0);
            }
        }

    }
}
