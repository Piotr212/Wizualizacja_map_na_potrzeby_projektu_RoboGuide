using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using UnityEngine.UI;

public class pobieranie_z_txt_do_tablic : MonoBehaviour {
	public string plik; //zmienna tekstowa
	private string _dane;//zmienna tekstowa
	public wzór_mapy WM; //odnośnik do klasy
	public Button przycisk;// odnośnik do obiektu UI button


	public void wczytywanie_mapy(){
		plik = przycisk.GetComponent<wybieranie_pliku> ().path;//przypisywanie wartości do zmiennej
		odczyt_z_XML ();//wykonanie funkcji
		WM = (wzór_mapy)deserializacja (_dane);//przypisanie wartości do danych klasy

	}
	void odczyt_z_XML()
	{
		StreamReader reader= File.OpenText(plik);//odczytuje zawartośc pliku
		string zawartość_pliku = reader.ReadToEnd();//przypisuje ciąg znaków z pliku
		reader.Close ();//wyłączenie
		_dane = zawartość_pliku;//przypisuje ciąg znaków
	}
	object deserializacja(string dane)
	{
		XmlSerializer serializerxml = new XmlSerializer (typeof( wzór_mapy ));//przypisuje wzór zapisu
		MemoryStream pamięć = new MemoryStream (do_tablicy(dane));//przypisuje dane
		XmlTextWriter writer = new XmlTextWriter (pamięć, Encoding.UTF8);//przetwarza dane
		return serializerxml.Deserialize (pamięć);//zwraca przetworzone dane
	}
	byte[] do_tablicy(string dane)
	{
		UTF8Encoding kodowanie = new UTF8Encoding ();//kodowane znaków
		byte[] tablica = kodowanie.GetBytes (dane);//przypisuje dane do tablicy
		return tablica;//zwraca tablicę
	}


}
