using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float velocidade = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.right * velocidade * Time.deltaTime * Mathf.Cos(Time.timeSinceLevelLoad), Space.World);
    }
}
