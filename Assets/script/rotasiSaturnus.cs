using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotasiSaturnus : MonoBehaviour {



void Update()
	{
		transform.Rotate ( new Vector3(Time.deltaTime*20,0,0));
	}
}