using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {

	public Canvas instructionMenu;
	public Button playText;
	public Button instructionText;
	public Button exitText;

	// Use this for initialization
	void Start () {

		instructionMenu = instructionMenu.GetComponent<Canvas> ();
		playText = playText.GetComponent<Button> ();
		instructionText = instructionText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		instructionMenu.enabled = false;
	}
	
	public void InstructionPress() {

		instructionMenu.enabled = true;
		playText.enabled = false;
		instructionText.enabled = false;
		exitText.enabled = false;

	}

	public void menuPress(){
		
			instructionMenu.enabled = false;
			playText.enabled = true;
			instructionText.enabled = true;
			exitText.enabled = true;

		}

	public void StartLevel(){
	
		SceneManager.LoadScene ("Mini game");

	}


	public void ExitGame(){

		Application.Quit ();

	}
}
