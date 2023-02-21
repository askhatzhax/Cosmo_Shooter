using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityForce : MonoBehaviour
{
    public float G = 0.07f;
    public GameObject[] Affectors;
    float Distance;
    Rigidbody2D Body;
    uint i;
    // Start is called before the first frame update
    void Start()
    {
        Body= GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0;i<Affectors.Length;i++)
        {
            Distance = Vector2.Distance(transform.position, Affectors[i].transform.position);
            Body.AddForce(((Affectors[i].transform.position - transform.position) / Distance) * (Body.mass * Affectors[i].GetComponent<Rigidbody2D>().mass*G)/(Distance*Distance+1));

        }
    }
}
