using UnityEngine;
using System.Collections;

public class przełącznik : MonoBehaviour {


	public void przypisanie(int wartość){
		GameObject.Find ("Main Camera").GetComponent<sterowanie_kamerą> ().przełącznik = wartość; //przypisywanie wartości
	}
}
