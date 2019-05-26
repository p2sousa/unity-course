using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInter : MonoBehaviour
{
    Light luz;

    // Start is called before the first frame update
    void Start()
    {
        luz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        luz.intensity = Mathf.Lerp(luz.intensity, 0f, Time.deltaTime/50f);
    }
}
