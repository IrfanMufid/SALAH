using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;

    HingeJoint Hinge;
    
    private void Start()
    {
        Hinge = GetComponent<HingeJoint>();
    }

    private void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        JointSpring jointspring = Hinge.spring;

        if (Input.GetKey(input))
        {
            jointspring.spring = 1000;
        }
        else
        {
            jointspring.spring = 0;
        }

        Hinge.spring = jointspring;
    }
}
