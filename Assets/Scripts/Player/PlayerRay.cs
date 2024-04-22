using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    public static float distanceFromTarget; //alacagımız nesnelere olan uzaklık olduğu içinjm bunu static yaptık böylece her yerden koda erişebiliriz
    public float toTarget;//Bu da gördugumuz nesnelere olan uzaklık kapı duvar veya herhangi bir nesne
    // Start is called before the first frame update
 
    void Update()
    {
       RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 100.0f));
        toTarget = hit.distance;
        distanceFromTarget = toTarget;

    }
}
