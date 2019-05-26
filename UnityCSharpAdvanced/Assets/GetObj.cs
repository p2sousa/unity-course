using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObj : MonoBehaviour
{
    GameObject capsule;
    // Start is called before the first frame update
    void Start()
    {
        capsule = GameObject.FindGameObjectWithTag("Cap");
        Destroy(capsule, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
