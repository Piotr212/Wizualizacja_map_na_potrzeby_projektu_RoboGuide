using UnityEngine;
using System.Collections;

public class aktywacja_znacznika_celu : MonoBehaviour {
	public GameObject obrazek;
	public GameObject punkt;
	string cel=null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		 cel = GameObject.Find ("Sterownik").GetComponent<wyznaczanie_celu> ().nazwa_celu;
		obrazek.SetActive (punkt.name == cel);
	}
}
