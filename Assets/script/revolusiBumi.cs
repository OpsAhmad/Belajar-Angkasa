using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revolusiBumi : MonoBehaviour {



void Update()
	{
		transform.Rotate ( new Vector3(Time.deltaTime*31,0,0));
	}
}
