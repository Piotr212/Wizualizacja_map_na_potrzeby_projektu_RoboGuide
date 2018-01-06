using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class przejście_do_folderu : MonoBehaviour {
	public string ścieżka_do_folderu;//zmienna tekstowa
	public string nazwa_folderu;//zmienna tekstowa
	public Button przycisk_do_poprzedniego;//odnośnik do obiektu UI typu button
	public Text tekst;//odnośnik do obiektu UI typu tekst

	public void od_folderu(){
		GameObject okno = GameObject.Find ("Panel_wyszukiwania");//odnośnik do obiektu i przypisanie do wartości
		okno.GetComponent<przeglądanie_plików> ().obecne_położenie = ścieżka_do_folderu;//przypisanie wartości
		if (!ścieżka_do_folderu.Contains(".txt")) {
			okno.GetComponent<przeglądanie_plików> ().lista_plików ();//wykonanie funkcji
			przycisk_do_poprzedniego.GetComponent<do_poprzedniego>().poprzednia=ścieżka_do_folderu;//przypisanie wartości
		}
	}
	void Update () {
		tekst.text = nazwa_folderu;//przypisanie wartości
		GameObject okno = GameObject.Find ("Panel_wyszukiwania");//odnośnik do obiektu i przypisanie wyszukanego obiektu
		if (!okno.GetComponent<przeglądanie_plików>().pliki.Contains(ścieżka_do_folderu)) {
				Destroy(gameObject);//usuwanie wskazanego obiektu
			}
		}

	}

