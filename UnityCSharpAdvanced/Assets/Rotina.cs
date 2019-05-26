using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotina : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("RotinaDeTeste");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator RotinaDeTeste()
    {
        yield return new WaitForSeconds(2.0f);
        Debug.Log("Rotina Executada");
    }
}
