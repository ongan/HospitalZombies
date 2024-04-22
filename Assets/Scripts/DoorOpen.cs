﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public float theDistance;
    public GameObject actionKey;
    public GameObject actionText;
    public GameObject hinge;
    public AudioSource doorSound;
 
    void Update()
    {
        theDistance = PlayerRay.distanceFromTarget;

      
    }
    private void OnMouseOver()
    {
        if (theDistance <= 2)
        {
            actionKey.SetActive(true);
            actionText.SetActive(true);
        }

        else
        {
            
        }
        if (Input.GetButton("Action"))
        {
            if (theDistance <= 2)
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                actionKey.SetActive(false);
                actionText.SetActive(false);
                hinge.GetComponent<Animation>().Play("MyDoorAnim");
                doorSound.Play();
            }
        }
            
    }
    private void OnMouseExit()
    {
        
        actionKey.SetActive(false);
        actionText.SetActive(false);
    }

}
