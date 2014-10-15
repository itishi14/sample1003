using UnityEngine;
using System.Collections;

public class MoveWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(0,0,0.09f);
		//Destroy(gameObject, 8.0f);
	}

	private void OnCollisionEnter(Collision collision){
				
		if (collision.gameObject.tag == "Human") {
			Destroy(gameObject);
						Debug.Log ("hit");
				}

		if (collision.gameObject.tag == "Delete") {
						Destroy (gameObject);
				}
		}
}
