using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFire1 : MonoBehaviour {


	public float velocidad;
	private Rigidbody2D elRB; 


	void Start () {
		velocidad = 10f;
		elRB = GetComponent<Rigidbody2D>();	
		Debug.Log ("Hola");
	}


	void Update () {
		elRB.velocity = new Vector2(0f,velocidad);
	}


	void OnBecameInvisible(){
		Destroy (this.gameObject);
		Debug.Log ("Hola");
	}
	void OnTriggerEnter(Collider objeto){
		Debug.Log ("Colisión con: ");
	}
}
