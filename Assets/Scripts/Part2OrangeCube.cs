using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part2OrangeCube : MonoBehaviour
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
        transform.position += Vector3.right * Mathf.Sin(Time.time * speed) * distance * Time.deltaTime;

    }
}
