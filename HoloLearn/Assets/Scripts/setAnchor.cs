using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setAnchor : MonoBehaviour
{
    public float x, y, z;


    public void Save()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;

        PlayerPrefs.SetFloat("anchorX", x);
        PlayerPrefs.SetFloat("anchorY", y);
        PlayerPrefs.SetFloat("anchorZ", z);

        Load();
    }

    public void Load()
    {
        x = PlayerPrefs.GetFloat("anchorX");
        y = PlayerPrefs.GetFloat("anchorY");
        z = PlayerPrefs.GetFloat("anchorZ");

        Vector3 LoadPosition = new Vector3(x, y, z);
        transform.position = LoadPosition + Camera.main.transform.position; ;
    }



}
