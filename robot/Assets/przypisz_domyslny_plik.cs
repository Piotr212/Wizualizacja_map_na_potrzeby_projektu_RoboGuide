using UnityEngine;
using System.Collections;

public class przypisz_domyslny_plik : MonoBehaviour {

    public GameObject mapa;
    public GameObject cel;

    public void przypisz()
    {
        mapa.GetComponent<wybieranie_pliku>().path = @"C:\mapa.txt";
        cel.GetComponent<wybieranie_pliku>().path = @"C:\cel.txt";
    }

}
