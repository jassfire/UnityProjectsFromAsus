﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject b = GameObject.Instantiate(bullet, transform.position, transform.rotation);
            Rigidbody rgd = GetComponent<Rigidbody>();
            rgd.velocity = transform.forward * speed;
        }
    }
}
