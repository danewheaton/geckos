using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gecko : MonoBehaviour
{
    [SerializeField] Transform[] zone1, zone2;

    [SerializeField] float speed = 1, minDistance = .1f;

    Transform currentNavPoint;

    private void Start()
    {
        ChangeNavPoint();
    }

    private void Update()
    {
        transform.position =
            Vector3.MoveTowards(transform.position, currentNavPoint.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, currentNavPoint.position) < minDistance)
            ChangeNavPoint();
    }

    private void ChangeNavPoint()
    {
        currentNavPoint = zone1[Random.Range(0, zone1.Length)];
    }
}
