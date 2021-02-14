using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSizeTwo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MakeBigger()
    {
        gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);

    }

    public void MakeSmaller()
    {
        gameObject.transform.localScale = new Vector3(1f, 1f, 1f);

    }
}
