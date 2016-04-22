﻿using UnityEngine;
using System.Collections;

public class MenuActions : MonoBehaviour {

	public TrackState trackState;
	public Canvas canvas;
	public GameObject initialPanel;
	public GameObject startGamePanel;
	public GameObject learnMorePanel;
	public GameObject aboutPanel;
	public GameObject optionsPanel;
	public GameObject quitPanel;

	public void StartRace() {
		//hide canvas
		canvas.enabled= false;
		initialPanel.SetActive (false);
		trackState.StartRace();
	}

	public void ShowInitial() {
		HideAllPanels ();
		initialPanel.SetActive (true);
	}

	public void ShowStartGame() {
		HideAllPanels ();
		startGamePanel.SetActive (true);
	}

	public void ShowLearnMore() {
		HideAllPanels ();
		learnMorePanel.SetActive (true);
	}

	public void ShowAbout() {
		HideAllPanels ();
		aboutPanel.SetActive (true);
	}


	public void ShowOptions() {
		HideAllPanels ();
		optionsPanel.SetActive (true);
	}
		
	public void ShowQuit() {
		HideAllPanels ();
		quitPanel.SetActive (true);
	}

	//used primarily to clear current visible panel
	private void HideAllPanels() {
		initialPanel.SetActive(false);
		startGamePanel.SetActive (false);
		learnMorePanel.SetActive(false);
		aboutPanel.SetActive(false);
		optionsPanel.SetActive(false);
		quitPanel.SetActive(false);
	}

}
