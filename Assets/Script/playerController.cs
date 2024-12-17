using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playerController : MonoBehaviour
{
    public float speed = 3f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playermovement();
    }

    private void playermovement()
    {
        float Xmove = Input.GetAxisRaw("Horizontal");

        Vector3 xposition = transform.position;
        xposition.x += Xmove * speed * Time.deltaTime;

        transform.position = xposition;


        float Ymove = Input.GetAxisRaw("Vertical");

        Vector3 yposition = transform.position;
        yposition.y += Ymove * speed * Time.deltaTime;

        transform.position = yposition;

    }
}
