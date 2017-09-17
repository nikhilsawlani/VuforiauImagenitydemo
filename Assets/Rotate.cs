using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	public int speedx;
	public int speedy;
	public int speedz;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate (new Vector3 (Time.deltaTime*speedx, Time.deltaTime * speedy,Time.deltaTime*speedz));
	}
}
