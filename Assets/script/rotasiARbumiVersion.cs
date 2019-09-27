using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotasiARbumiVersion : MonoBehaviour {
void Update()
	{
		transform.Rotate ( new Vector3(Time.deltaTime*0,5,0));
	}
}
