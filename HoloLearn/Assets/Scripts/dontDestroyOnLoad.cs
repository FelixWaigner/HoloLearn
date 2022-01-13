using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroyOnLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject obj;
    public void dontDestroy()
    {
        DontDestroyOnLoad(obj);
    }
}
