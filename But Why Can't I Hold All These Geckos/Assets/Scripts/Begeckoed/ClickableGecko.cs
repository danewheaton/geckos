using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableGecko : MonoBehaviour
{
    private void OnMouseDown()
    {
        GeckoSwapper swapper = FindObjectOfType<GeckoSwapper>();

        if (swapper.firstSelectedGecko == null)
        {
            swapper.firstSelectedGecko = transform;
        }
        else if (swapper.secondSelectedGecko == null)
        {
            swapper.secondSelectedGecko = transform;
            StartCoroutine(swapper.SwapGeckos());
        }
    }
}
