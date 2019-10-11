using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateMushroom : MonoBehaviour
{
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        sound.Play();
    }
}
