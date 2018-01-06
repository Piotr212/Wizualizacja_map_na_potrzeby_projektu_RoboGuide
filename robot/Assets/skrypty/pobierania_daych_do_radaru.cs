using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;
public class pobierania_daych_do_radaru : MonoBehaviour {

	public string ścieżka;//zmienna tekstowa
	string ostatni_zapis;//zmienna tekstowa
	public List<string>dane=new List<string>();//odnośnik do obiektu
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
				GameObject robot=GameObject.FindWithTag("robot");
				if (robot!=null&&dane.Count>0) {
					robot.GetComponent<radar>().sondowanie(dane);
				}
			}
			
		}
	}
	void read()
	{
		dane.Clear ();
		string curline; //zmienna tekstowa
		System.IO.StreamReader file = new System.IO.StreamReader(ścieżka);//szczytywanie zawartości wskazaneko pliku
		while((curline = file.ReadLine()) != null)
		{
			dane.Add(curline);//przypisywanie wartości
		}
		
	}
}
