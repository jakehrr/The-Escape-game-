using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // Wheel Collider Fields
    [SerializeField] WheelCollider FLWC;
    [SerializeField] WheelCollider FRWC;
    [SerializeField] WheelCollider BLWC;
    [SerializeField] WheelCollider BRWC;
    // Wheel Transform fields
    [SerializeField] Transform FLW;
    [SerializeField] Transform FRW;
    [SerializeField] Transform BLW;
    [SerializeField] Transform BRW;
   
    // Public Variables
    public float motorTorque = 900f;
    public float maxSteering = 30f;
    public Transform centerOfMass;

    // Private Variables
    private Rigidbody carRb;

    // Start is called before the first frame update
    void Start()
    {
        // Access car rigidbody 
        carRb = GetComponent<Rigidbody>();
        // Do something with the centre of mass
        carRb.centerOfMass = centerOfMass.localPosition;
    }

    // Fixed update used as motor torque and steering angle use physics 
    void FixedUpdate()
    { // put relevent physics based methods in here
        HandleMotor();
    }
  
    private void Update()
    { // put relevent non-physics based methods in here
        WheelRotation();
    }

    private void HandleMotor()
    {
        // Access vertical axis for player acceleration and breaking
        FLWC.motorTorque = Input.GetAxis("Vertical") * motorTorque;
        FRWC.motorTorque = Input.GetAxis("Vertical") * motorTorque;
        // Access horizontal axis for player turning
        FLWC.steerAngle = Input.GetAxis("Horizontal") * maxSteering;
        FRWC.steerAngle = Input.GetAxis("Horizontal") * maxSteering;
    }

    private void WheelRotation()
    {
        // Set the positions and rotations
        var pos = Vector3.zero;
        var rot = Quaternion.identity;

        // Left side wheel rotations 
        FLWC.GetWorldPose(out pos, out rot);
        FLW.position = pos;
        FLW.rotation = rot * Quaternion.Euler(0, 180, 0);
       
        BLWC.GetWorldPose(out pos, out rot);
        BLW.position = pos;
        BLW.rotation = rot * Quaternion.Euler(0, 180, 0);
        
        // Right side wheel rotations
        FRWC.GetWorldPose(out pos, out rot);
        FRW.position = pos;
        FRW.rotation = rot;

        BRWC.GetWorldPose(out pos, out rot);
        BRW.position = pos;
        BRW.rotation = rot;
    }
}
