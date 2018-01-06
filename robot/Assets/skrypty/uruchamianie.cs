using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class uruchamianie : MonoBehaviour {
	public GameObject obiekt;//odnośnik do obiektu
	public Button przycisk_ścieżki;// odnośnik do obiektu UI button
	public Button przycisk_mapy;// odnośnik do obiektu UI button
	public void do_sceny()
	{
		DontDestroyOnLoad (obiekt);//aktywowanie funkcji ktura sprawia że nie usuwa się wskazany obiekt przy przejściu do nowej scenny
		Application.LoadLevel ("mapa");//przejście do wybranej scenny

	}

	void Update () {
		if (przycisk_ścieżki.GetComponent<wybieranie_pliku>().path.Length!=0 && przycisk_mapy.GetComponent<wybieranie_pliku>().path.Length!=0) {
			gameObject.GetComponent<Button>().interactable=true;//przypisywanie wartości
		}
		else {
			gameObject.GetComponent<Button>().interactable=false;//przypisywanie wartości
		}
		
	}
}
