using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Write : MonoBehaviour{
    public SerialPort sp = new SerialPort("COM3", 9600);
    // Start is called before the first frame update
    void Start(){
        sp.Open();
        
    }

    // Update is called once per frame
    void Update(){
        if (sp.IsOpen)
        {
            if (Input.GetKey("a"))
            {
                sp.Write("1");
                print(1);
            }
            else if (Input.GetKey("b"))
            {
                sp.Write("0");
                print(0);
            }
        }
        
    }
}
