using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public GameObject player;
    private int move = 0;
    private Vector3 movement;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (move-- > 0) {
            player.transform.position += movement;
        }
	}

    public void onTeleportToObject(GameObject targetGameObject) {
        movement = (new Vector3(
            targetGameObject.transform.position.x,
            player.transform.position.y,
            targetGameObject.transform.position.z + 6) - player.transform.position)/40;
        move = 40;
        /*
        player.transform.position = new Vector3(
            targetGameObject.transform.position.x-3, 
            player.transform.position.y, 
            targetGameObject.transform.position.z+3);
            */
    }

}
