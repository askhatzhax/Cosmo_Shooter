using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform shotpos1;
    public Transform shotpos2;
    public GameObject Bullet;
    void Start()
    {

    } 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet, shotpos1.transform.position, transform.rotation);
            Instantiate(Bullet, shotpos2.transform.position, transform.rotation);
            SoundManager.Instance.PlayOneShot(SoundManager.Instance.Shot);
        }
    }
}
