﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotasiBumi : MonoBehaviour {



void Update()
	{
		transform.Rotate ( new Vector3(Time.deltaTime*0,20,0));
	}
}