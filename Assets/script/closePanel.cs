using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closePanel : MonoBehaviour {
public AudioSource tapSFX;
public AudioSource backSfx;
public GameObject obyekPanel;
	// Use this for initialization
	public void buka(){
		obyekPanel.SetActive(true);
		tapSFX.Play();
	}

	public void tutup(){
		obyekPanel.SetActive(false);
		backSfx.Play();
	}
}
