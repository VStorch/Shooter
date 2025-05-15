using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float magnitude = 0.3f;
    private bool emX;
    private bool emY;
    private bool emZ;

    // Start is called before the first frame update
    void Start()
    {
        emX = (Random.value > 0.6f);
        emY = (Random.value > 0.6f);
        emZ = (Random.value > 0.6f);
    }

    // Update is called once per frame
    void Update()
    {
        // Movimento em X
        if (emX)
        {
            gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * magnitude, Space.World);
        }

        // Movimento em Y
        if (emY) 
        {
            gameObject.transform.Translate(Vector3.back * Mathf.Cos(Time.timeSinceLevelLoad) * magnitude, Space.World);
        }

        // Movimento em Z
        if (emZ)
        {
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * magnitude, Space.World);
        }
    }
}