using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togglePanel : MonoBehaviour
{
    public GameObject panel;

    public void showPanel()
    {
        bool isActive = panel.activeSelf;

        panel.SetActive(!isActive);
    }
}
