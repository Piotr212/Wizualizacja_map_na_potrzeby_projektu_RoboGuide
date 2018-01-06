using UnityEngine;
using System.Collections;

public class pozycja_z : MonoBehaviour {

	void Update () {
		GameObject teren = GameObject.Find ("Terrain");//odnośnik do wyszukiwanego obiektu
		gameObject.GetComponent<długość_x> ().z = teren.GetComponent<Terrain> ().terrainData.size.z;//zmiana wartości parametru
	}
}
