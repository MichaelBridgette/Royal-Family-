using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void goDevRoom()
    {
        Application.LoadLevel("DevRoom");
    }

    public void goBack()
    {
        Application.LoadLevel("Scene");
    }
    public void goFitzgeralds()
    {
        Application.LoadLevel("Fitzgerald Room");
    }
}
