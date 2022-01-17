using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleActive : MonoBehaviour
{

    public GameObject enable;
    public GameObject disable;


 
    public void enableInstruction()
    {
        enable.SetActive(true);

    }

    public void disableInstruction()
    {
        disable.SetActive(false);
    }
}
