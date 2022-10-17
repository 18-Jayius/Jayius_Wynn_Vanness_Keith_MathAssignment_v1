using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part3BlueCube : MonoBehaviour
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


        this.transform.position += transform.up  * Mathf.Sin(Time.time * speed) * distance * Time.deltaTime;
        this.transform.position += transform.right * Mathf.Cos(Time.time * speed) * distance * Time.deltaTime;
    }
}
