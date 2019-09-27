using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revolusiBumi1 : MonoBehaviour {



void Update()
	{
		transform.Rotate ( new Vector3(Time.deltaTime*0,10,0));
	}
}