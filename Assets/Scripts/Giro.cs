using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class Giro : MonoBehaviour
{
    public float velocidade = 90f;
    private bool x, y, z;

    // Start is called before the first frame update
    void Start()
    {
        x = (Random.value > 0.5);
        y = (Random.value > 0.5);
        z = (Random.value > 0.5);
    }

    // Update is called once per frame
    void Update()
    {
        if (y)
            gameObject.transform.Rotate(Vector3.up * velocidade * Time.deltaTime, Space.World);
        if (x)
            gameObject.transform.Rotate(Vector3.right * velocidade * Time.deltaTime, Space.World);
        if (z)
            gameObject.transform.Rotate(Vector3.back * velocidade * Time.deltaTime, Space.World);
    }
}
