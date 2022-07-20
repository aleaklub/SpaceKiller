using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
    
{
    public GameObject Hert1;
    public GameObject Hert2;
    public GameObject Hert3;
    public GameObject BrokHp1;
    public GameObject BrokHp2;
    public GameObject BrokHp3;
    public static int HPcount = 3;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (HPcount == 2)
        {
            Hit1();
           
        }
        if (HPcount == 1)
        {
            Hit2();
        }
        if (HPcount == 3)
        {
            Hert3.SetActive(true);
            Hert2.SetActive(true);
            BrokHp3.SetActive(false);
            BrokHp2.SetActive(false);
        }
    }
    public void Hit1()
    {
        Hert3.SetActive(false);
        BrokHp3.SetActive(true);

    }
    public void Hit2()
    {
        Hert2.SetActive(false);
        BrokHp2.SetActive(true);
    }
    
    
}
