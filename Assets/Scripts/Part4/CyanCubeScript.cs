using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyanCubeScript : MonoBehaviour
{
    public GameObject bluecube;
    public GameObject bullet;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dirvec = bluecube.transform.position - this.transform.position;
        transform.forward = dirvec;


        if(Input.GetKeyDown(KeyCode.Space))
        {
            
            Instantiate(bullet, this.transform.position, transform.rotation);
            
        }   
    }
}
