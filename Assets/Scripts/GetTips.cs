using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using mlConnect;
using UnityEngine.UI;

public class GetTips : MonoBehaviour {

	// Use this for initialization
	void Start () {
        apiConnect.connect();
        gameObject.GetComponent<Text>().text = apiConnect.Tips;
	}
	
	// Update is called once per frame
	void Update () {
		
	}



}
