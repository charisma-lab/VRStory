using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move Right
        if(Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
        }
        // Move Left
        else if(Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
        }
        // Move Down
        else if(Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
        }
        // Move Up
        else if(Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
        }

        // --------------------------------------------------------------------------------- //

        // Go forward
        else if (!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0,0,speed * Time.deltaTime));
        }
        // Go backward
        else if (!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0,0,-speed * Time.deltaTime));
        }
        // Turn Right
        else if (!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0,20 * speed * Time.deltaTime, 0));
        }
        // Turn Left
        else if (!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0,-20 * speed * Time.deltaTime, 0));
        }


        // ----------------------------------------------------------------------------------- //

        // Look Up
        else if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(-10 * speed * Time.deltaTime, 0, 0));
        }
        // Look Down
        else if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(10 * speed * Time.deltaTime, 0, 0));
        }
    }
}
