using UnityEngine;
using System.Collections;

public class długość_z : MonoBehaviour {

	public float x;//zmienna liczbowa
	

	void Update () {
		GameObject teren = GameObject.Find ("Terrain"); //odnośnik do wyszukiwanego obiektu

		float z = teren.GetComponent<Terrain> ().terrainData.size.z; //przypisanie wartości do zmiennej
		
		gameObject.transform.position= new Vector3(x,3f,z/2);//zmiana wartości parametru
		gameObject.transform.localScale = new Vector3 (0f, 6f, z);//zmiana wartości parametru
		
	}

}
