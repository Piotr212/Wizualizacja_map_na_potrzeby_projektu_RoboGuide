using UnityEngine;
using System.Collections;

public class wybierz_plik : MonoBehaviour {
	public GameObject obiekt_potrzebujący_pliku;//odnośnik do obiektu
	public GameObject panel;//odnośnik do obiektu

	public void przypisanie_pliku(){
		obiekt_potrzebujący_pliku.GetComponent<wybieranie_pliku> ().path = panel.GetComponent<przeglądanie_plików> ().obecne_położenie;//przypisanie wartości
		panel.SetActive (false);//zmiana wartości parametru typu bool
	}
}
