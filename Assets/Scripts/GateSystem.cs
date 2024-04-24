using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateSystem : MonoBehaviour
{
    Animator anim;
    public AudioSource gate;
    void Start()
    {
        
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("Gate", true);
            gate.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("Gate", false);
            gate.Play();
        }
    }

}
