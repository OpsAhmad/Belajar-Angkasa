using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revolusiVenus : MonoBehaviour {



void Update()
	{
		transform.Rotate ( new Vector3(Time.deltaTime*33,0,0));
	}
}