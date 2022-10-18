using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part3 : MonoBehaviour
{
    public GameObject bluecube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dirvec = bluecube.transform.position - this.transform.position;
        transform.forward = dirvec;
    }
}
