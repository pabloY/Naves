using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJuego : MonoBehaviour {
	public GameObject enemigo;
	private float cronometro;
	private float periodoBombasActual;
	public float periodoBombas;

	// Use this for initialization
	void Start () {
		cronometro = 0f;
		periodoBombasActual = periodoBombas+Random.Range(-0.5f,0.5f);
		InvokeRepeating ("Periodicamente", 0f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		if (cronometro > periodoBombasActual) {
			Instantiate(enemigo,new Vector3(Random.Range(-8.5f,8.5f),7f,0f),new Quaternion());
			cronometro = 0f;
			periodoBombasActual = periodoBombas+Random.Range(-0.5f,0.5f);
			periodoBombas = 1f;
		}
		cronometro+=Time.deltaTime;
	}

	void FixedUpdate(){
		//Time.fixedDeltaTime = 1f;
		Debug.Log ("FIXED: "+Time.fixedDeltaTime);
	}

	void Periodicamente(){
		Debug.Log ("Periodicamente");
	}
}
