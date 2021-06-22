using UnityEngine;

public class IncrementCorrectScore : MonoBehaviour
{
	void Start () {
		int newScoreCorrect = 1 + PlayerPrefs.GetInt("scoreCorrect");
		PlayerPrefs.SetInt("scoreCorrect", newScoreCorrect);
	} 
}