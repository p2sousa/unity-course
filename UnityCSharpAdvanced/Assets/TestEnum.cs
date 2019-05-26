using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnum : MonoBehaviour
{
    public enum Luminosidade{baixo, medio, alto};
    public Luminosidade nivelLuz;
    Light luz;
    // Start is called before the first frame update
    void Start()
    {
        luz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (nivelLuz == Luminosidade.baixo)
        {
            luz.intensity = 0.2f;
        } else if (nivelLuz == Luminosidade.medio)
        {
            luz.intensity = 0.7f;
        } else if (nivelLuz == Luminosidade.alto)
        {
            luz.intensity = 1.2f;
        }
    }
}
