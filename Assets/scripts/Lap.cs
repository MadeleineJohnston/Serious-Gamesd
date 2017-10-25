using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lap : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		GameObject.Find ("Player").SendMessage ("Finish");
	}
}
