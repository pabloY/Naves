using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBomba : MonoBehaviour {
	private Rigidbody2D miRB;

	// Use this for initialization
	void Start () {
		miRB = GetComponent<Rigidbody2D> ();
		miRB.velocity = new Vector2(0f,-5f);
	}
	
	// Update is called once per frame
	void Update () {
//		if(transform.position.y<-7f){
//			Destroy (this.gameObject);
//		}
	}
	void OnBecameInvisible(){
		Destroy (this.gameObject);


	}
	// + objeto.transform.name
	void OnTriggerEnter(Collider objeto){
		Debug.Log ("Colisión con: ");
	}
}
