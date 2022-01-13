using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPosition : MonoBehaviour
{
    public playerPrefs playerPrefs;

    // Start is called before the first frame update
    void Start()
    {
        playerPrefs.Load();
    }
}