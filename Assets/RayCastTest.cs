using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray r = new Ray(transform.position,Vector3.down*3);

        Debug.DrawRay(r.origin, r.direction);
        Debug.Log("updating");
    }
}
