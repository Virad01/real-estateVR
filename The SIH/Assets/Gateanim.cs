using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gateanim : MonoBehaviour
{
    Animator gateAnim;
    void Start()
    {
        gateAnim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //gateAnim.SetTrigger("GateAnim");
        Debug.Log("Player Collided");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Animation Playing");

            gateAnim.SetTrigger("GateAnim");
        }
    }
}
