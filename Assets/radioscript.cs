using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radioscript : MonoBehaviour
{
    public AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "HTC_Vive_controller")
            music.mute = !music.mute;
    }
}
