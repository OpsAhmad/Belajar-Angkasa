using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revolusiCeres : MonoBehaviour {



void Update()
	{
		transform.Rotate ( new Vector3(Time.deltaTime*26,0,0));
	}
}