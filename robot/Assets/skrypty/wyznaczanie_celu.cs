using UnityEngine;
using System.Collections;


public class wyznaczanie_celu : MonoBehaviour {
	GameObject przetearzanie_pliku_do_listy;//odnośnik do obiektu
    public string nazwa_celu=null;//zmienna tekstowa
	GameObject robot;//odnośnik do obiektu
	public GameObject prefab;//odnośnik do obiektu

	void Update () {
		if (GameObject.Find("przetearzanie_pliku_do_listy")) {
			przetearzanie_pliku_do_listy=GameObject.Find("przetearzanie_pliku_do_listy");//przypisanie obiektu
			nazwa_celu=przetearzanie_pliku_do_listy.GetComponent<przetwarzanie_pliku_txt>().cel;//przypisanie wartości
			if (nazwa_celu.Length!=0) {
				if (GameObject.FindWithTag("robot")==null) {
					if (GameObject.Find(nazwa_celu)!=null) {
					robot=Instantiate(prefab,GameObject.Find(nazwa_celu).transform.position, GameObject.Find(nazwa_celu).transform.rotation) as GameObject;//dodanie nowego obiektu i przypisanie obiektu
					}
				}
				else {
					
						if (GameObject.Find(nazwa_celu)!=null) {

                        
						GameObject cel=GameObject.Find(nazwa_celu);//odnośnik do obiektu iprzypisanie wartości
						robot.GetComponent<poruszanie_robotem>().cel=cel;//przypisanie obiektu
	
						}
                    
					}
				}
			
		}
	}
}
