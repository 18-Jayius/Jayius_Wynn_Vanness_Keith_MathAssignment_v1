using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part2YellowCube : MonoBehaviour
{
    public float speed;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* float x = transform.position.x;
        float y = Mathf.Cos(Time.time);
        float z = transform.position.z;

        transform.position = new Vector3(x, y, z); */

        transform.position += Vector3.up * Mathf.Sin(Time.time * speed) * distance * Time.deltaTime;
    }
}
