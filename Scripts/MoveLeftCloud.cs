using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCloud : MonoBehaviour
{
    void Start() {}
	public bool origin = false;
	// Start is called before the first frame update
    public void Move()
    {
        if(origin) {
		transform.position = new Vector3(-2,0,4);
		origin = false;
	}
	else {
		transform.position = new Vector3(0,-30,0);
		origin = true;
	}
	
	while (!origin) {
		transform.position += Vector3.up * Time.deltaTime;
	}
    }
}
