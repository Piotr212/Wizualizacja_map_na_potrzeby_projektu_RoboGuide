using UnityEngine;
using System.Collections;

public class powrot : MonoBehaviour {

	public void powrot_do_menu(){
		GameObject obiekt = GameObject.Find ("przetearzanie_pliku_do_listy");//znajduje szukany obiekt
		Destroy (obiekt);//niszczy obiekt
		Application.LoadLevel("Menu");//przechodzi do innej sceny
	}
}
