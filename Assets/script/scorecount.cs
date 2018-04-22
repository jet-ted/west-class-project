using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class scorecount : MonoBehaviour {

	public int count;
	public Text score;

	void Start () {
		count = 0;
		score.text = "Gold - 0";
	}
	
	// Update is called once per frame
	public void goldpickup () {
		count = count + 1;
		setcounttext ();
	}

	void setcounttext(){
		score.text = "Gold - " + count.ToString ();
	}
}
