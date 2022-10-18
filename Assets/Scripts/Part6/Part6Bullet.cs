using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part6Bullet : MonoBehaviour
{
    public float speed = 10f;
    public GameObject bluecube;
    
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 dirvec = bluecube.transform.position - this.transform.position;

        transform.forward = dirvec.normalized;

        transform.position += Vector3.MoveTowards(transform.position, bluecube.transform.position, );

    }
      
    
}
