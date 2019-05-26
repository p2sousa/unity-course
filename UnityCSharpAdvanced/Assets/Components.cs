using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Components : MonoBehaviour
{
    Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        myLight.intensity = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        // myLight.intensity -= 0.0005f;
    }
}
