using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ensiklopedia : MonoBehaviour {

int counting;
public AudioSource tapSFX;
public AudioSource backSfx;
public GameObject obyekPanel;

	public void Start(){
		counting = 0;
	}
	// Use this for initialization
	public void bukaTutup(){
		if(counting==1){
		obyekPanel.SetActive(false);
		backSfx.Play();
		counting = 0;
		}else{
		obyekPanel.SetActive(true);
		tapSFX.Play();
		counting++;
		}
	}

}
