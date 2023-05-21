using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;

	
    void Start() {

    }
    void Update() {
    Instantiate(objectToSpawn);
    }

}
