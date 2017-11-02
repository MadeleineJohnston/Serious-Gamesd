using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rand_Num_Gen : MonoBehaviour {

    int sumNums;

	// Use this for initialization
	void Start () {
        sumNumsBig = Random.Range(100, 999);
        sumNumsSmall = Random.Range(2, 50); 
    }
	
	// Update is called once per frame
	void Update () {

        //generate and display 7 rand numbers (3 big, 4 small)

        GUI.Label(Rect(10, 10, 100, 30), "1" + sumNumsBig); //generic co-ords for now - make random positionining within the region of the play area
        GUI.Label(Rect(20, 10, 100, 30), "2" + sumNumsBig);
        GUI.Label(Rect(30, 10, 100, 30), "3" + sumNumsBig);
        GUI.Label(Rect(40, 10, 100, 30), "4" + sumNumsSmall);
        GUI.Label(Rect(50, 10, 100, 30), "5" + sumNumsSmall);
        GUI.Label(Rect(60, 10, 100, 30), "6" + sumNumsSmall);
        GUI.Label(Rect(70, 10, 100, 30), "7" + sumNumsSmall);
    }
}
