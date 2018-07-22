using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeckoGrid : MonoBehaviour
{
    [SerializeField] GameObject[] geckos;
    [SerializeField] int gridSize = 8;
    [SerializeField] float spacing = .1f;

    private void Start()
    {
        for (int x = 0; x < gridSize; x++)
        {
            for (int y = 0; y < gridSize; y++)
            {
                GameObject gridPiece = Instantiate(geckos[Random.Range(0, geckos.Length)]);

                gridPiece.transform.position = new Vector2((gridPiece.transform.position.x + x) * spacing, (gridPiece.transform.position.y + y) * spacing);
            }
        }
    }
}
