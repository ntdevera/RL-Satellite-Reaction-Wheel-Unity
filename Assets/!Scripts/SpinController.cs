using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpinController : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotSpeed3= 0;
    public float rotspeedlimit =10;
    public Rigidbody rb3;
    
    void Start()
    {	rb3 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {	
        if(Input.GetKey(KeyCode.W)){
        	this.rotSpeed3=this.rotspeedlimit;
        	rb3.AddTorque(transform.up*this.rotSpeed3);
        }
        if(Input.GetKey(KeyCode.S)){
        	this.rotSpeed3=-this.rotspeedlimit;
        	rb3.AddTorque(transform.up*this.rotSpeed3);
        }
        
        
   	rotSpeed3 *= 0.96f;
	
    }
}
