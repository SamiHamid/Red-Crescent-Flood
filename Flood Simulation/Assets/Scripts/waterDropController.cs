﻿using UnityEngine;
using System.Collections;

public class waterDropController : MonoBehaviour {

	public Material _waterDropMat;
	public float _smoothness;
	public float _speed;




	void Start () {
		
		_smoothness = _waterDropMat.GetFloat ("_Glossiness");



	}
	

	void Update () {
		

		_waterDropMat.SetFloat ("_Glossiness", _smoothness);

		_smoothness = Mathf.PingPong (_speed * Time.time, 1f);

	
	}
}
