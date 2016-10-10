using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour {

	public int _PlayerScore;
	private int playerScore;

	public Text _PlayerScoreText;


	// Use this for initialization
	void Start () {
		_PlayerScore = 0;

		_PlayerScoreText.text = _PlayerScore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// SCRIPT API //

	public void HitByBullet()
	{
		//_PlayerScore += 10;
		AddToPlayerScore(10);
		//Debug.Log("I GOT HIT BY A BULLET!");
	}

	public void AddToPlayerScore(int addSCore)
	{
		_PlayerScore = _PlayerScore + addSCore;
		_PlayerScoreText.text = _PlayerScore.ToString();
		Debug.Log("SCORE IS NOW: " + _PlayerScore);
	}
}
