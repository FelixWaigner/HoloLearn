using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setHologramPosition : MonoBehaviour
{
    public hologramPosition HologramPosition;

    // Start is called before the first frame update
    void Start()
    {
        HologramPosition.LoadHologram();
    }
}