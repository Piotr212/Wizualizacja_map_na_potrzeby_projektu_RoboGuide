using UnityEngine;
using System.Collections;
using System.IO;

public class automatyczne_przypisanie : MonoBehaviour {
	public GameObject pliki;
	public GameObject przetwarzane_dane;
	public GameObject start;
	// Use this for initialization
	void Start () {
		if (File.Exists(@"C:\mapa.txt")&&File.Exists(@"C:\cel.txt")) 
		{
			pliki.GetComponent<przypisz_domyslny_plik> ().przypisz ();
			przetwarzane_dane.GetComponent<pobieranie_z_txt_do_tablic> ().wczytywanie_mapy();
			start.GetComponent<uruchamianie> ().do_sceny ();
		} else {
			Debug.Log ("a");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
