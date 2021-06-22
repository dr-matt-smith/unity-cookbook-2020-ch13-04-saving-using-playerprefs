using UnityEngine;

public class IncrementIncorrectScore : MonoBehaviour
{
	void Start () {
		int newScoreIncorrect = 1 + PlayerPrefs.GetInt("scoreIncorrect");
		PlayerPrefs.SetInt("scoreIncorrect", newScoreIncorrect);
	} 
}
