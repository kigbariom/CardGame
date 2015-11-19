using UnityEngine;
using System.Collections.Generic;

public class Player {



	public string characterName;
	public bool hasCommittedCards = false;
	public int favor;
	public List<Vector2> hand = new List<Vector2> ();
	
	public Player(){
		this.characterName = "";
		this.favor = 0;
		drawCards ();
	}
	public Player(string aCharacterName){
		this.characterName = aCharacterName;
		drawCards();
	}
	
	//one more card in your hand than the number of players
	public void drawCards(){
		while (this.hand.Count <= GameSystem.gameSystem.numberOfCards) {
			int x = Random.Range(0, 2);
			int y = Random.Range(0, 2);
			if(x == 0) {
				if(y == 0){
					this.hand.Add (new Vector2(0, -1));
				}
				else {
					this.hand.Add(new Vector2(0, 1));
				}
			}
			else {
				if(y == 1) {
					this.hand.Add(new Vector2(-1, 0));
				}
				else {
					this.hand.Add(new Vector2(1, 0));
				}
			}
		}
	}

//	pulbic void calculateEffectOfPlayedCards(){
//
//	}
	
	// @Matt just fill thous out with what it needs to do
	public void adjustFavor(int favorEffect)
	{
		// Code that adds the favor effect to their favor
		this.favor += favorEffect;
	}
}
