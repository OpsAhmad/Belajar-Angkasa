using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationSUN : MonoBehaviour {



void Update()
	{
		transform.Rotate ( new Vector3(Time.deltaTime*10,0,0));
	}
}