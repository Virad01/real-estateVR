using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatesphere : MonoBehaviour
{
    Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        movement = new Vector3(0, 1, 0);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(movement);

    }
}
