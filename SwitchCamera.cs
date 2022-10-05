using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SwitchCamera : MonoBehaviour
{
    [FormerlySerializedAs("Maincamera")] public GameObject cam1;

    [FormerlySerializedAs("CameraInsideCar")] public GameObject cam2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Switch1"))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        if (Input.GetButtonDown("Switch2"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
