using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidBodyComponet;
    public int K=4;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rigidBodyComponet= GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Vector2 forward1 = transform.up * Input.GetAxis("Vertical")*K;
        Vector2 right = transform.right * Input.GetAxis("Horizontal")*K;
        //rigidBodyComponet.AddForce((right)* Time.fixedDeltaTime*200);
        //rigidBodyComponet.AddForce((forward) * Time.fixedDeltaTime * 200);
        rigidBodyComponet.velocity = forward1 + right;//задаем ускорение
        //rigidBodyComponet.AddForce(transform.up * YForce, ForceMode2D.Impulse);
        transform.Rotate(transform.up, Input.GetAxis("Mouse X")*10);//поворот относительно оси ”
    }
    void Update()
    {
        /*if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            SoundManager.Instance.PlayOneShot(SoundManager.Instance.Move);
        }
        */
    }
}
