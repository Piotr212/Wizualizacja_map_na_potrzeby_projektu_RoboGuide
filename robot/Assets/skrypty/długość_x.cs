using UnityEngine;
using System.Collections;

public class długość_x : MonoBehaviour {
    
	public float z;//zmienna liczbowa


	void Update () {
		GameObject teren = GameObject.Find ("Terrain"); //odnośnik do wyszukiwanego obiektu

		float x = teren.GetComponent<Terrain> ().terrainData.size.x;//przypisanie wartości do zmiennej

		gameObject.transform.position= new Vector3(x/2,3f,z);//zmiana wartości parametru
		gameObject.transform.localScale = new Vector3 (x, 6f, 0f); //zmiana wartości parametru
		
	}

}
