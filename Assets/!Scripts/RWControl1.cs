using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RWControl1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotSpeed1= 0;
    public float rotSpeed2= 0;
    public float rotSpeed3= 0;
    public float rotSpeed4= 0;
    public float motorForce=1;
    
    public WheelCollider RW1W;
    public Transform RW1T;
    
    public void GetInput()
    {
    	RW1_input1 = Convert.ToSingle(Input.GetKey(KeyCode.W));
    	RW1_input2 = Convert.ToSingle(Input.GetKey(KeyCode.S));
    }
  
    public void Accelerate()
    {
    	RW1W.motorTorque = RW1_input1 * motorForce;
    	RW1W.motorTorque = -RW1_input2 * motorForce;
    }
    
    public void UpdateWheelPoses()
    {
    	transform.Rotate(0,0,motorForce);
    }
    
    
    void Start()
    {	
    }

    // Update is called once per frame
    void Update()
    {	GetInput();
        Accelerate();
        UpdateWheelPoses();
	
    }
    
    private float RW1_input1;
    private float RW1_input2;
}
