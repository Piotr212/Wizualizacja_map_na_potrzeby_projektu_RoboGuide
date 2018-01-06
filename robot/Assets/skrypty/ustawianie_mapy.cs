using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ustawianie_mapy : MonoBehaviour
{
	bool czy_wygenerować = true;//znienna typu bool i przypisanie wartości
	GameObject przetwornik;//oddnośnik do obiektu
	public GameObject prefab_pola;//oddnośnik do obiektu

	void Update ()
	{
		if (czy_wygenerować) {
			przetwornik = GameObject.Find ("przetearzanie_pliku_do_listy");//przypisanie znalezionego obiektu
			if (przetwornik != null) {
				wzór_mapy WM = przetwornik.GetComponent<pobieranie_z_txt_do_tablic> ().WM;//zmienna wzór_mapy i przypisanie wartości
				double[,] north = new double[WM.ilość_punktów_x, WM.ilość_punktów_y];//tablica liczbowa 
				double[,] south = new double[WM.ilość_punktów_x, WM.ilość_punktów_y];//tablica liczbowa 
				double[,] east = new double[WM.ilość_punktów_x, WM.ilość_punktów_y];//tablica liczbowa 
				double[,] west = new double[WM.ilość_punktów_x, WM.ilość_punktów_y];//tablica liczbowa 
				double[,] obstacles = new double[WM.ilość_punktów_x, WM.ilość_punktów_y];//tablica liczbowa
				double x = 0;//przypisywanie wartości
				double y = 0;//przypisywanie wartości
				north = zwróć_tablice (WM.north);// przypisanie wartości za pomocą funkcji
				south = zwróć_tablice (WM.south);//przypisanie wartości za pomocą funkcji
				east = zwróć_tablice (WM.east);//przypisanie wartości za pomocą funkcji
				west = zwróć_tablice (WM.west);//przypisanie wartości za pomocą funkcji
				obstacles = zwróć_tablice (WM.obstacles);//przypisanie wartości za pomocą funkcji
				for (int i = 0; i < WM.ilość_punktów_x; i++) {
					x += north [i, 0];//przypisywanie wartości
					x += south [i, 0];//przypisywanie wartości
				}
				for (int i = 0; i < WM.ilość_punktów_y; i++) {
					y += east [0, i];//przypisywanie wartości
					y += west [0, i];//przypisywanie wartości
				}
				gameObject.GetComponent<Terrain> ().terrainData.size = new Vector3 ((float)x, 10f, (float)y);
				x = 0;//przypisywanie wartości
				y = 0;//przypisywanie wartości
				GameObject punkt;//odnośnik do obiektu
				for (int i = 0; i <WM.ilość_punktów_x; i++) {

					for (int j = 0; j < WM.ilość_punktów_y; j++) {
						if (i==0) {
							x+=north[i,j];//przypisywanie wartości
						}
						else {
							for (int k = 0; k < i; k++) {
								x+=north[k,j];//przypisywanie wartości
								x+=south[k,j];//przypisywanie wartości
							}
							x+=north[i,j];//przypisywanie wartości
						}

						y+=west[i,j];
						punkt=Instantiate(prefab_pola,new Vector3((float)x,0f,(float)y),prefab_pola.transform.rotation)as GameObject;//dodanie nowego obiektu i przypisywanie obiektu
						punkt.name=(i+1)+","+(j+1);//przypisywanie wartości
						punkt.transform.GetChild(0).gameObject.transform.localScale=new Vector3((float)(north[i,j]+south[i,j]),10f,(float)(east[i,j]+west[i,j]));//przypisywanie wartości
						punkt.transform.GetChild(0).gameObject.SetActive(obstacles[i,j]==1); //przypisywanie wartości                                                                           
						y+=east[i,j];//przypisywanie wartości
						x=0;//przypisywanie wartości
					}

					y=0;//przypisywanie wartości
				}
				czy_wygenerować = false;//przypisywanie wartości
			}
		}


	
	}

	private double[,] zwróć_tablice (List<string>lista)
	{
		wzór_mapy WM = przetwornik.GetComponent<pobieranie_z_txt_do_tablic> ().WM;//przypisywanie wartości
		double[,] tablica = new double[WM.ilość_punktów_x, WM.ilość_punktów_y];//tablica liczbowa
		foreach (var item in lista) {
			string[] podział = item.Split ('=');//tablica tekstowa i przybisanie podzielonej zmiennej
			string[] podział1 = podział [0].Split (',');//tablica tekstowa i przybisanie podzielonej zmiennej
			int x = int.Parse (podział1 [0]);//zmienna liczbowa i przydzielenie wartości
			int y = int.Parse (podział1 [1]);//zmienna liczbowa i przydzielenie wartości
			if (podział[1].Contains(",")) {
				podział1 = podział [1].Split (',');// przybisanie podzielonej zmiennej
				podział[1]=podział1[0]+"."+podział1[1];//przypisanie wartości
			}
			tablica [x - 1, y - 1] = double.Parse (podział [1]);//przypisanie wartości
			
		}
		return tablica;//zwrót wartości
	}
}
