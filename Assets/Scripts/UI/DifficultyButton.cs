using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DifficultyButton : MonoBehaviour 
{
    [SerializeField] private TMP_Text buttonText;
    public int index = 0;
	string[] difficultyNames = { "Easy", "Medium", "Hard" };

	private void Start() {
		buttonText.SetText(difficultyNames[index]);
	}

	public void iterateDifficulty() {
		if(index + 1 <= difficultyNames.Length - 1) {
			index++;
		} else {
			index = 0;
		}
		buttonText.SetText(difficultyNames[index]);
	}
}
