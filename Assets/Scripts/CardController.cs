using UnityEngine;
using System.Collections;

public class CardController : MonoBehaviour {
	
	Vector3 dummy1 = new Vector3(0.0f, 0.0f, 0.0f);
		
	public void translateVectorToDICard(Vector2 cardPoint, int i){
		GameObject cardObject = (GameObject) Instantiate (Resources.Load("Card"), dummy1, Quaternion.identity);
		cardObject.name = "Card " + i;
	}
}
