using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class responsiveCam : MonoBehaviour {

public Camera kamera_saya;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			transform.LookAt (transform.position + kamera_saya.transform.rotation * Vector3.back,
			kamera_saya.transform.rotation * Vector3.up);
	}
}
