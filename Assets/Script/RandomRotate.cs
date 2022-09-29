using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(Random.value, Random.value, Random.value));
        this.transform.RotateAround(Vector3.zero, Vector3.up, 0.1f);
    }
}
