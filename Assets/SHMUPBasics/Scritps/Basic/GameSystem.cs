using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour {

	enum SateOfGame { 
		Start, 
		Playing, 
		ScoreScreen, 
		End
	}
	//public SateOfGame _StageOfGame;

	public int _PlayerScore;
	private int playerScore;

	public Text _PlayerScoreText;

	GameSystem.SateOfGame _StateOfGame;


	// Use this for initialization
	void Start () {


		_StateOfGame = SateOfGame.Start;
		_PlayerScore = 0;

		_PlayerScoreText.text = _PlayerScore.ToString();
	}
	
	// Update is called once per frame
	void Update () {

		StateManager();
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

	private void StateManager()
	{
		/*
		if(_StageOfGame == SateOfGame.Start)
		{
			//DO SOMETHING
		} 
		else if(_StageOfGame == SateOfGame.Playing)
		{
			//Do More Stuff
		}
		else if(_StageOfGame == SateOfGame.ScoreScreen)
		{
			//SHow Score stuff	
		}
		else 
		{
			
		}
*/

		switch (_StateOfGame)
		{
		case SateOfGame.Start:
			//DO SOMETHIg
			break;
		case SateOfGame.Playing:
			//Do More Stuff
			break;
		case SateOfGame.ScoreScreen:
			break;
		default:
			break;
		}
		
	}
}
