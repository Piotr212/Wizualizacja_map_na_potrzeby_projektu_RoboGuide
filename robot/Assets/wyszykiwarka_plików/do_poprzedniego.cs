using UnityEngine;
using System.Collections;

public class do_poprzedniego : MonoBehaviour {
	public GameObject okno;//odnośnik do obiektu
	public string[]w;//tablica tekstu
	public string s;//zmienna tekstowa
	public string poprzednia;//zmienna tekstowa

	public void poprzedni(){
		string[] podzielona_ścieżka= okno.GetComponent<przeglądanie_plików> ().obecne_położenie.Split ('\\');//tablica tekstowa i przypisanie podzielonego tekstu
		w = podzielona_ścieżka;//przypisanie wartości
		if (podzielona_ścieżka.Length>1) {

			 string nowa_ścieżka=null;//zmienna tekstowa
			for (int i = 0; i < podzielona_ścieżka.Length-1; i++) {
					if (i==podzielona_ścieżka.Length-3) {
					if (podzielona_ścieżka[i+1].Contains(".txt")) {
						nowa_ścieżka+=podzielona_ścieżka[i];//przypisanie wartości
						if (podzielona_ścieżka.Length==2) {
							nowa_ścieżka+=@"\";//przypisanie wartości
						}
						break;
					}
					}
				if (i==podzielona_ścieżka.Length-2) {
					nowa_ścieżka+=podzielona_ścieżka[i];//przypisanie wartości
					if (podzielona_ścieżka.Length==2) {
						nowa_ścieżka+=@"\";//przypisanie wartości
					}
				}
				else {
					nowa_ścieżka+=podzielona_ścieżka[i]+@"\";//przypisanie wartości
				}
					

			}

			s=nowa_ścieżka;//przypisanie wartości
			okno.GetComponent<przeglądanie_plików> ().obecne_położenie =nowa_ścieżka;//przypisanie wartości
			if (poprzednia!=nowa_ścieżka) {
				okno.GetComponent<przeglądanie_plików>().lista_plików();//wykonanie funkcji
			}
			poprzednia=nowa_ścieżka;//przypisanie wartości
			
		}
	}

}
