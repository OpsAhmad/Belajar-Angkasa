using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSceneKLIK : MonoBehaviour {

//mengganti scene
public AudioSource klikSFX;
	public void ChangeScene(string sceneName)
	{
			Application.LoadLevel(sceneName);
			klikSFX.Play();

	}	

}
