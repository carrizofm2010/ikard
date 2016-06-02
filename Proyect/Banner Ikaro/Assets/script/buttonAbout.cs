using UnityEngine;
using System.Collections;

public class buttonAbout : MonoBehaviour {

	public GameObject imagen;
	// Use this for initialization
	private static bool estado=false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void mostrarImagen(){
		estado = !estado;
		imagen.SetActive (estado);
	}
}
