using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Room1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
   void OnTriggerEnter(Collider other) {
        SceneManager.LoadSceneAsync("SampleScene", LoadSceneMode.Single);
    } 
}
