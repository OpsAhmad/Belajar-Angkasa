﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revolusiMars: MonoBehaviour {



void Update()
	{
		transform.Rotate ( new Vector3(Time.deltaTime*28,0,0));
	}
}