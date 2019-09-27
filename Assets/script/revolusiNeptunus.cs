using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revolusiNeptunus : MonoBehaviour {



void Update()
	{
		transform.Rotate ( new Vector3(Time.deltaTime*5,0,0));
	}
}