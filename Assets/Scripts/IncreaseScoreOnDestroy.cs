using UnityEngine;
using System.Collections;

public class IncreaseScoreOnDestroy : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		if (player == null)
			player = GameObject.FindWithTag("Player");
	}
	
	void OnDestroy () {
		player.SendMessage ("IncreaseScore");
	}
}
