using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objToggle : MonoBehaviour
{
    public GameObject obj;
    public bool startActive;

    // Start is called before the first frame update
    void Start()
    {
        obj.SetActive(startActive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision with " + other.gameObject.name);
        if (other.gameObject.name.Contains("HTC_Vive_controller"))
            obj.SetActive(!obj.activeSelf);
    }
}
