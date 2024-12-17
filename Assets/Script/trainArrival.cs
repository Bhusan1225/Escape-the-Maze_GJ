using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainArrival : MonoBehaviour
{
    public float trainSpeed = 2f;
    public Vector3 pointA;
    public Vector3 pointB;
    private Vector3 targetPoint;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = pointA;
        targetPoint = pointB;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPoint, trainSpeed * Time.deltaTime);
        if (transform.position == targetPoint)
        {
            targetPoint = (targetPoint == pointA) ? pointB : pointA;
        }
    }
}
