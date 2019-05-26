using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject obj;
    float z = 1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("generateObj", 1f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            generateObj();
        }
    }

    void generateObj()
    {
        Instantiate(obj, new Vector3(z,z,z), Quaternion.identity);
        z += 1f;
    }
}
