﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	//	We call this method to destroy the projectile
	public void Hit() {
		Destroy (gameObject);
	}

	//	Getter for the damage property.
	public float getDamage() {
		return Destroy(HeartScore);
	}
}