using UnityEngine;
using System.Collections;

public class sterowanie_kamerą : MonoBehaviour {
	public GameObject teren;
	private RectTransform ramka;
	private float maxY;
	private float maxX;
	public int przełącznik;
	public float prętkość_oddalania;
	private float oddalenie;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x=0f;
		float y=0f;
		float z=0f;

		switch (przełącznik) {
		case 1:
			x = teren.GetComponent<Terrain> ().terrainData.size.x/2;
			z = teren.GetComponent<Terrain> ().terrainData.size.z/2;
			y = teren.GetComponent<Terrain> ().terrainData.size.x;
			oddalenie=0f;
			break;
		case 2:
			if (GameObject.Find("robot")!=null) {
				GameObject robot=GameObject.Find("robot");
				x=robot.transform.position.x;
				z=robot.transform.position.z;

					
				
				if (Input.GetAxis("Mouse ScrollWheel")>0 && oddalenie>-34f)
				{
					oddalenie-=prętkość_oddalania;
				}
				if (Input.GetAxis("Mouse ScrollWheel")<0) 
				{
					oddalenie+=prętkość_oddalania;
				}
				if (oddalenie<-34f) {
					oddalenie=0f;
				}
				y=40f+oddalenie;
			}
			else {
				przełącznik=1;
			}
			break;
		
		}


		gameObject.transform.position = new Vector3 (x, y, z);
	}
}
