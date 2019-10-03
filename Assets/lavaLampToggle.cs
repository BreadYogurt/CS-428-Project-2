﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavaLampToggle : MonoBehaviour
{
    public GameObject light;

    // Start is called before the first frame update
    void Start()
    {
        light = GameObject.Find("Lava Lamp Light");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision with " + other.gameObject.name);
        if (other.gameObject.name.Contains("HTC_Vive_controller"))
            light.SetActive(!light.activeSelf);
    }
}
