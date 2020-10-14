using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RWControl2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotSpeed2= 0;
    public float rotspeedlimit2;
    void Start()
    {	
    }

    // Update is called once per frame
    void Update()
    {	
        if(Input.GetKey(KeyCode.E)){
        	this.rotSpeed2=rotspeedlimit2;
        }
        if(Input.GetKey(KeyCode.D)){
        	this.rotSpeed2=-rotspeedlimit2;
        }
        transform.Rotate(0,0,this.rotSpeed2);
        this.rotSpeed2 *=0.96f;
	
    }
}
