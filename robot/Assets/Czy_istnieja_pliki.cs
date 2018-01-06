using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class Czy_istnieja_pliki : MonoBehaviour {
	public Text tekst;
	// Use this for initialization
	void Start () {
        if (!(File.Exists(@"C:\mapa.txt")&&File.Exists(@"C:\cel.txt")))
        {
			gameObject.GetComponent<Button> ().interactable = false;
			tekst.text = "Brak plików domyślnych";
        }
	}
	
}
