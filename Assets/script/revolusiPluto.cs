using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revolusiPluto: MonoBehaviour {



void Update()
	{
		transform.Rotate ( new Vector3(Time.deltaTime*3,0,0));
	}
}