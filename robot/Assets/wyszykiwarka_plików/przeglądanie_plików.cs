using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;
public class przeglądanie_plików : MonoBehaviour {
	public Button przycisk_startowy;//odnośnik do obiektu UI typu button
	public string obecne_położenie;//zmienna tekstowa
	public List<string>pliki=new List<string>();//lista typu string
	public List<string>wyświetlane_pliki = new List<string> ();//lista typu string
	public Button prefab_folderu;//odnośnik do obiektu UI typu button
	public GameObject panel;//odnośnik do obiektu

	public void lista_plików()
	{
	if (obecne_położenie!="") {
			pliki.Clear();//czyszczenie listy

			foreach (string file in Directory.GetDirectories(obecne_położenie))
			{
				pliki.Add(file);//dodanie wartości do listy
			}
			foreach (string file in Directory.GetFiles(obecne_położenie)) {
				if (file.Contains(".txt")) {
					pliki.Add(file);//dodanie wartości do listy
				}
			}
			float i=0;//zmienna liczbowa i przypisanie wartości
			int j=0;//zmienna liczbowa i przypisanie wartości
			foreach (string item in pliki) {
				Button przycisk= Instantiate(prefab_folderu) as Button;//dodanie obiektu i przypisanie wartości
				przycisk.GetComponent<RectTransform>().parent=panel.GetComponent<RectTransform>();//przypisanie komponętu

				i=i+30f;//przypisanie wartości
				przycisk.GetComponent<RectTransform>().anchoredPosition=new Vector2(0f,przycisk_startowy.GetComponent<RectTransform>().anchoredPosition.y-i);//przypisanie wartości
				przycisk.GetComponent<RectTransform>().sizeDelta=new Vector2(0f,przycisk_startowy.GetComponent<RectTransform>().sizeDelta.y);//przypisanie wartości
				przycisk.GetComponent<przejście_do_folderu>().ścieżka_do_folderu=item;//przypisanie wartości
				string[]podzielona_ścieżka=item.Split('\\');//tablica tekstu i przypisanie podzielonego tekstu
				przycisk.GetComponent<przejście_do_folderu>().nazwa_folderu=podzielona_ścieżka[podzielona_ścieżka.Length-1];//przypisanie wartości
				przycisk.GetComponent<przejście_do_folderu>().przycisk_do_poprzedniego=przycisk_startowy;//przypisanie wartości
				j+=1;//przypisanie wartości
				if (j>10) {
					panel.GetComponent<RectTransform>().offsetMin=new Vector2(0f,-(j-10)*30f);//przypisanie wartości

				}
				else {
					panel.GetComponent<RectTransform>().offsetMin=new Vector2(0f,0f);//przypisanie wartości
				}

			}

		}
	}
}
