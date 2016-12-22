using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public float speed =5f,jumpspeed=2f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


			transform.Translate (speed * Time.deltaTime, 0, 0);

		if (Input.GetButtonDown ("Jump")) {
			
		//	transform.Translate (0, jump * Time.deltaTime,0);

		

		} 

	}


	void OnCollisionEnter2D (Collision2D col)
	{
		

		if(col.gameObject.tag=="obstacle")
		Destroy (gameObject);
	}

}
