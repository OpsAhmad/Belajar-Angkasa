using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revolusiUranus : MonoBehaviour {



void Update()
	{
		transform.Rotate ( new Vector3(Time.deltaTime*8,0,0));
	}
}