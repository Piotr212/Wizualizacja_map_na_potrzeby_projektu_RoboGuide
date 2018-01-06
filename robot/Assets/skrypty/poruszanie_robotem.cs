using UnityEngine;
using System.Collections;

public class poruszanie_robotem : MonoBehaviour {
	public GameObject cel; //odnośnik do obiektu
	NavMeshAgent agent;//odniośnik do komponentu 
	void Start () {
		agent = gameObject.GetComponent<NavMeshAgent> ();//przypisanie komponentu
	}

	void Update () {
	    if (cel!=null) {
			agent.SetDestination(cel.transform.position);//uruchomienie funkcji 
		}
	}
}
