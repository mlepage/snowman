using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public int score = 0;
	public GameObject scoreLabel;

	public void IncreaseScore () {
		++score;
		scoreLabel.guiText.text = "Score: " + score;
	}

}
