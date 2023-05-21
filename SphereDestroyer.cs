using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "Sphere(Clone)") {
            Destroy(gameObject,3);
	}
    }

}
