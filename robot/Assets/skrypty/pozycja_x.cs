using UnityEngine;
using System.Collections;

public class pozycja_x : MonoBehaviour {


	void Update () {
		GameObject teren = GameObject.Find ("Terrain");//odnośnik do wyszukiwanego obiektu
		gameObject.GetComponent<długość_z> ().x = teren.GetComponent<Terrain> ().terrainData.size.x;//zmiana wartości parametru
	}
}
