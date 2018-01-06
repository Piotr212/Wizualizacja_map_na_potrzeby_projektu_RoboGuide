using UnityEngine;
using System.Collections;

public class Zamykanie_okna : MonoBehaviour {

	public GameObject okno;//odnośnik do obiektu
	public void zamykanie()
	{
		okno.SetActive (false);//zmiana wartości parametru typu bool
	}
}
