using UnityEngine;
using System.Collections;

public class BaseRepeat : MonoBehaviour {


	Vector3 place = new Vector3(12,-4,0);

	public GameObject base1;

	// Use this for initialization
	void Start () {
	
		InvokeRepeating ("inst", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
	


		//transform.Translate (5*Time.deltaTime,0,0);

	}

	void inst (){
		
		Instantiate (base1,place,transform.rotation);
		place.x += 8;
	}
}
