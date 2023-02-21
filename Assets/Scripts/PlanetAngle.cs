using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetAngle : MonoBehaviour
{
    public Transform TargetPlanet;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        Quaternion rotation= Quaternion.FromToRotation(-transform.right,TargetPlanet.position-transform.position);
        transform.rotation= rotation*transform.rotation;        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
