using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class wybieranie_pliku : MonoBehaviour {
	public Text text; //odnośnik do obiektu UI text
	public string path;//zmienna tekstowa
	public GameObject zapis;//odnośnik do obiektu
	public Button przycisk_zatwierdzania;// odnośnik do obiektu UI button
	public void przypisanie_obiektu(){
		przycisk_zatwierdzania.GetComponent<wybierz_plik>().obiekt_potrzebujący_pliku=gameObject;//przupisanie obiektu


	}

	void Update () {
		text.text = path; //przypisanie wartości
	   
	}
}
