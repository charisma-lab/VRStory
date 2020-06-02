using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurguryTable : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Sparks01;
    public GameObject Sparks02;
    public GameObject Sparks03;
    public GameObject Sparks04;
    public GameObject Sparks05;
    public GameObject Sparks06;
    public GameObject Sparks07;
    public GameObject Sparks08;
    public GameObject Sparks09;
    public GameObject Sparks10;
    public GameObject Sparks11;
    public GameObject Sparks12;
    public GameObject Sparks13;
    public GameObject Sparks14;
    public GameObject Sparks15;
    public GameObject Sparks16;
    public GameObject Sparks17;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SparkEffect01()
    {
        Sparks16.SetActive(false);
        Sparks17.SetActive(false);

        Sparks01.SetActive(true);
    }
    void SparkEffect02()
    {
        Sparks01.SetActive(false);

        Sparks02.SetActive(true);
        Sparks03.SetActive(true);
    }
    void SparkEffect03()
    {
        Sparks02.SetActive(false);
        Sparks03.SetActive(false);

        Sparks04.SetActive(true);
    }
    void SparkEffect04()
    {
        Sparks04.SetActive(false);
        
        Sparks05.SetActive(true);
    }
    void SparkEffect05()
    {
        Sparks05.SetActive(false);

        Sparks06.SetActive(true);
        Sparks07.SetActive(true);
    }
    void SparkEffect06()
    {
        Sparks06.SetActive(false);
        Sparks07.SetActive(false);

        Sparks08.SetActive(true);
        Sparks09.SetActive(true);
    }
    void SparkEffect07()
    {
        Sparks08.SetActive(false);
        Sparks09.SetActive(false);

        Sparks10.SetActive(true);
        Sparks11.SetActive(true);

    }
    void SparkEffect08()
    {
        Sparks10.SetActive(false);
        Sparks11.SetActive(false);

        Sparks12.SetActive(true);
        Sparks13.SetActive(true);
    }
    void SparkEffect09()
    {
        Sparks12.SetActive(false);
        Sparks13.SetActive(false);

        Sparks14.SetActive(true);
        Sparks15.SetActive(true);
    }
    void SparkEffect10()
    {
        Sparks14.SetActive(false);
        Sparks15.SetActive(false);

        Sparks16.SetActive(true);
        Sparks17.SetActive(true);
    }
}
