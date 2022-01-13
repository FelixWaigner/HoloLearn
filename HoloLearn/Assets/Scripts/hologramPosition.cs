using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hologramPosition : MonoBehaviour
{

    public float xHologram, yHologram, zHologram;


    public void SaveHologram()
    {
        xHologram = transform.position.x;
        yHologram = transform.position.y;
        zHologram = transform.position.z;

        PlayerPrefs.SetFloat("xHologram", xHologram);
        PlayerPrefs.SetFloat("yHologram", yHologram);
        PlayerPrefs.SetFloat("zHologram", zHologram);
    }

    public void LoadHologram()
    {
        xHologram = PlayerPrefs.GetFloat("xHologram");
        yHologram = PlayerPrefs.GetFloat("yHologram");
        zHologram = PlayerPrefs.GetFloat("zHologram");

        Vector3 LoadPosition = new Vector3(xHologram, yHologram, zHologram);
        transform.position = LoadPosition;
    }
}
