using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSceneBack : MonoBehaviour {

//mengganti scene
public AudioSource backSFX;
	public void ChangeScene2(string sceneName)
	{
			Application.LoadLevel(sceneName);
			backSFX.Play();

	}	

}
