using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class otwieranie_wyszukiwania : MonoBehaviour {
	public GameObject okno;//odnośnik do obiektu
	public void otwieranie()
	{
		okno.SetActive (true);//zmiana wartości parametru typu bool
		okno.GetComponent<przeglądanie_plików> ().obecne_położenie = @"C:\Users";//przypisanie wartości
		okno.GetComponent<przeglądanie_plików> ().lista_plików ();//wykonanie funkcji
	
	}

}
