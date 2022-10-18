using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part6Bullet : MonoBehaviour
{
    public float speed = 25f;
    public GameObject bluecube;
    
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        bluecube = GameObject.FindWithTag("BlueCube");
        Vector3 dirvec = bluecube.transform.position - this.transform.position;

        transform.forward = dirvec.normalized;

        transform.position += transform.forward * speed * Time.deltaTime;
        Destroy(gameObject, 4f);

    }
      
    
}
