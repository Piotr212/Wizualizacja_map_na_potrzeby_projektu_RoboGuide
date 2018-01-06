using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class radar : MonoBehaviour {

	// Use this for initialization
	public List<GameObject>obiekty=new List<GameObject>();
	public GameObject prefabrykant;
	private GameObject robot;
	public void  sondowanie(List<string> dane){
		float kont = 0;
		GameObject obiekt=gameObject;
		float a1=0;
		float b1 = 0;
        foreach (var item in obiekty)
        {
            Destroy(item);
        }
        foreach (var item in dane) {
			Quaternion obrot=new Quaternion(gameObject.transform.rotation.x,gameObject.transform.rotation.y,gameObject.transform.rotation.z,gameObject.transform.rotation.w);
			
			
			string[] podzial=item.Split(':');
			int dystans=int.Parse(podzial[1]);
			kont=int.Parse(podzial[0]);
			float a=Mathf.Sin(kont)*dystans;
			float b=Mathf.Cos(kont)*dystans;
			if (kont!=0) {
				obiekt= Instantiate(prefabrykant,gameObject.transform.position,obrot) as GameObject;
				obiekty.Add(obiekt);
				obiekt.AddComponent<MeshFilter> ();
				obiekt.AddComponent<MeshRenderer> ();
				Mesh mesh =obiekt.GetComponent<MeshFilter> ().mesh;
				mesh.Clear ();
				mesh.vertices = new Vector3[] {new Vector3 (0, 1, 0), new Vector3 (a1, 1, b1), new Vector3 (a, 1, b)};
				mesh.uv = new Vector2[] {new Vector2 (0, 0), new Vector2 (0, 1), new Vector2 (1, 1)};
				mesh.triangles = new int[] {0, 1, 2};
			}
			a1=a;
			b1=b;
			
		}


	}
	public Vector3 pozycja_robota=new Vector3(0,0,0);
	public Vector3 w1;
	void Update (){
		robot = GameObject.FindGameObjectWithTag ("robot");

		if (robot!=null) {
			if(pozycja_robota.x!=robot.transform.position.x ||pozycja_robota.z!=robot.transform.position.z){
				foreach (var item in obiekty) {
					Destroy(item);
				}
			}
			pozycja_robota=robot.transform.position;

		}
	}


}
