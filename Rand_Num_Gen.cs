using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rand_Num_Gen : MonoBehaviour {

   // int sumNumsBig1, sumNumsBig2, sumNumsBig3, sumNumsSmall1, sumNumsSmall2, sumNumsSmall3, sumNumsSmall4;
    public Text numberText;

    // Use this for initialization
    void Start () {
        //sumNumsBig = Random.Range(100, 999);
        //sumNumsSmall = Random.Range(2, 50); 
        numberText.text = "1";// + sumNumsBig1.ToString("");
        numberText.text = "2";// + sumNumsBig2.ToString("");
        numberText.text = "3";// + sumNumsBig3.ToString("");
        numberText.text = "4";// + sumNumsSmall1.ToString("");
        numberText.text = "5";// + sumNumsSmall2.ToString("");
        numberText.text = "6";// + sumNumsSmall3.ToString("");
        numberText.text = "7";// + sumNumsSmall4.ToString("");
    }
	
	// Update is called once per frame
	void Update () {

        //generate and display 7 rand numbers (3 big, 4 small)
      
    }
}
