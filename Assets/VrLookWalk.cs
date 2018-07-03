using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrLookWalk : MonoBehaviour {


    public Transform vrCam;

    public float toggleAngle = 30.0f;

    public float speed = 3.0f;

    public bool moveForward;

    private CharacterController cc;
	// Use this for initialization
	void Start () {
        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		if(vrCam.eulerAngles.x >= toggleAngle&& vrCam.eulerAngles.x<90.0f)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }

        if(moveForward)
        {
            Vector3 forward = vrCam.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);
        }
	}
}
