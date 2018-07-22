using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeckoSwapper : MonoBehaviour
{
    [SerializeField] float geckoSwapTimer = 1;

    public Transform firstSelectedGecko, secondSelectedGecko;

    public IEnumerator SwapGeckos()
    {
        Vector3 firstGeckoPos = firstSelectedGecko.position,
            secondGeckoPos = secondSelectedGecko.position;

        float elapsedTime = 0;
        while (elapsedTime < geckoSwapTimer)
        {
            firstSelectedGecko.position = Vector3.Lerp(firstGeckoPos, secondGeckoPos, elapsedTime / geckoSwapTimer);
            secondSelectedGecko.position = Vector3.Lerp(secondGeckoPos, firstGeckoPos, elapsedTime / geckoSwapTimer);

            yield return new WaitForEndOfFrame();
            elapsedTime += Time.deltaTime;
        }

        firstSelectedGecko.position = secondGeckoPos;
        secondSelectedGecko.position = firstGeckoPos;

        RefreshGeckos();
    }

    private void RefreshGeckos()
    {
        firstSelectedGecko = null;
        secondSelectedGecko = null;
    }
}
