using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Updates : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Tempo do Update:" + Time.deltaTime);
    }

    void FixedUpdate()
    {
        Debug.Log("Tempo do Fixed Update:" + Time.deltaTime);
    }

    void LateUpdate()
    {
        Debug.Log("Tempo do Late Update:" + Time.deltaTime);
    }
}
