﻿using UnityEngine;
using System.Collections;

public class CoffinController : MonoBehaviour, Iinteractable {
	public void Interact(PlayerController playercontroller){
		gameObject.transform.parent = playercontroller.transform;
	}

	public void StopInteract(PlayerController playercontroller) {
		gameObject.transform.parent = null;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
