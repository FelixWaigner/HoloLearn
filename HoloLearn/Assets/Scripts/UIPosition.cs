using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPosition : MonoBehaviour
{
    public GameObject ui;
    public Vector3 xyz;

    public void saveUI()
    {
        xyz = ui.transform.position;
    }

    public void loadUI()
    {
        ui.transform.position = xyz;
    }
}