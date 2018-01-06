using UnityEngine;
using System.Collections;

public class zmiana_dysku : MonoBehaviour {

public void nowy_dysk(string nazwa){
		gameObject.transform.parent.gameObject.GetComponent<przeglądanie_plików> ().obecne_położenie = nazwa + @":\";
		gameObject.transform.parent.gameObject.GetComponent<przeglądanie_plików> ().lista_plików ();

	}
}
