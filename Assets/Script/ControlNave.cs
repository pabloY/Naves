using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNave : MonoBehaviour {
	public float velocidad;
	public GameObject Fire1;
	// Use this for initialization
	GameObject nave;
	void Start () {
		velocidad = 10f;
	}
	
	// Update is called once per frame
	void Update () { 
		//transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z);
		//transform.position = new Vector3(transform.position.x+Input.GetAxis("Horizontal"),transform.position.y,transform.position.z);
		//transform.position = new Vector3(transform.position.x+Input.GetAxis("Horizontal")*velocidad*Time.deltaTime,transform.position.y,transform.position.z);
		transform.position = new Vector3(Mathf.Clamp(transform.position.x+Input.GetAxis("Horizontal")*velocidad*Time.deltaTime,-7.5f,7.5f),transform.position.y,transform.position.z);
		if (Input.GetButtonDown("Fire1"))
			Instantiate(Fire1,this.transform.position,Quaternion.identity);
	}
	void OnTriggerEnter(Collider objeto){
		Debug.Log ("Colisión con: ");
	}
}
