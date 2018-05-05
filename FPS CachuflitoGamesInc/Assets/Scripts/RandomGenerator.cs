using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour {

    public GameObject prefab_1;
    public GameObject prefab_2;
    public GameObject prefab_3;
    public GameObject prefab_4;
    public GameObject prefab_5;
    public GameObject prefab_6;
    public GameObject prefab_7;
    public GameObject prefab_8;
    public GameObject prefab_9;
   

    public int ancho;
    public int largo;
    private int random;
    //private int rotacion;
    // Use this for initialization
    void Start () {
       

        for (int i = 0; i < ancho; i++)
        {
            for (int j = 0; j < largo; j++)
            {
                random = Random.Range(0, 9);
              //  rotacion = Random.Range(0, 5);
                switch (random)
                {
                    case 0:
                        Instantiate(prefab_1, new Vector3(i * 20, 1, j * 20), Quaternion.identity);                        
                        break;
                    case 1:
                        Instantiate(prefab_2, new Vector3(i * 20, 1, j * 20), Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(prefab_3, new Vector3(i * 20, 1, j * 20), Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(prefab_4, new Vector3(i * 20, 1, j * 20), Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(prefab_5, new Vector3(i * 20, 1, j * 20), Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(prefab_6, new Vector3(i * 20, 1, j * 20), Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(prefab_7, new Vector3(i * 20, 1, j * 20), Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(prefab_8, new Vector3(i * 20, 1, j * 20), Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(prefab_9, new Vector3(i * 20, 1, j * 20), Quaternion.identity);
                        break;
                    default:
                        break;
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
