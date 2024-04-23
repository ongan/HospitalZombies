using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosedDoor : MonoBehaviour
{
    public float theDistance;
    public GameObject actionKey;

    public GameObject closedDoorText;
    public AudioSource doorSound;
    public float waitingSeconds;

    void Update()
    {
        theDistance = PlayerRay.distanceFromTarget;


    }
    private void OnMouseOver()
    {
        if (theDistance <= 2)
        {
            actionKey.SetActive(true);
            

        }

        else
        {

        }
        if (Input.GetButton("Action"))
        {
            if (theDistance <= 2)
            {
                
                actionKey.SetActive(false);
                closedDoorText.SetActive(true);
                StartCoroutine(ClosedDoors());
                doorSound.Play();
            }
        }

    }
    private void OnMouseExit()
    {
        actionKey.SetActive(false);               


    }
    IEnumerator ClosedDoors()
    {
        yield return new WaitForSeconds(waitingSeconds);
        closedDoorText.SetActive(false);
    }
}
