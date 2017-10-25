using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {

	Image fill;
	float timeAmount = 10;
	float time;
	public Text countdownText;

	// Use this for initialization
	void Start () {

		fill = this.GetComponent<Image> ();
		time = timeAmount;

	}
	
	// Update is called once per frame
	void Update () {

		if (time > 0) {
			time -= Time.deltaTime;
			fill.fillAmount = time / timeAmount;
			countdownText.text = "Time: " + time.ToString ("F");
		}

	}

}
