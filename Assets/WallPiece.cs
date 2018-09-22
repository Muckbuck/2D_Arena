using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPiece : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
        int x = 0;
        int y = 0;
        GameObject wall_block = Resources.Load("wall_block", typeof(GameObject)) as GameObject;
        Instantiate(wall_block, transform.position, this.transform.rotation);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
