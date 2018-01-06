using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class przetwarzanie_pliku_txt : MonoBehaviour {
	public string ścieżka;//zmienna tekstowa
	string ostatni_zapis;//zmienna tekstowa
	public string cel;//odnośnik do obiektu
	public GameObject przycisk;// odnośnik do obiektu UI button
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevel==0) {
			ścieżka=przycisk.GetComponent<wybieranie_pliku>().path;//przypisywanie wartości
		}

	if (ścieżka.Length!=0) {
			if (ostatni_zapis!=""+File.GetLastWriteTime(ścieżka)) {
				read();//wykonywanie funkcji
				ostatni_zapis=""+File.GetLastWriteTime(ścieżka);//przypisywanie wartości
			}

		}
	}
	void read()
	{

		string curline; //zmienna tekstowa
		System.IO.StreamReader file = new System.IO.StreamReader(ścieżka);//szczytywanie zawartości wskazaneko pliku
		while((curline = file.ReadLine()) != null)
		{
			cel = curline;//przypisywanie wartości
		}

	}
}
