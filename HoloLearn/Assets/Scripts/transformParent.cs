using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformParent : MonoBehaviour
{
    public GameObject setParent;

    public void SetParent()
    {
        gameObject.transform.parent = setParent.transform;
    }
}
