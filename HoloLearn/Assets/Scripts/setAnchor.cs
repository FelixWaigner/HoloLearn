using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setAnchor : MonoBehaviour
{
    public GameObject Anweisungen;

   public void setAnchorPosition()
    {
        Vector3 imgXYZ = GameObject.Find("ImageTarget").transform.position;
        Anweisungen.transform.position = imgXYZ;
        Anweisungen.SetActive(true);

        //Anweisungen.transform.parent = GameObject.Find("PositionAnchor").transform;
        //Anweisungen.SetActive(true);
    }

    

}
