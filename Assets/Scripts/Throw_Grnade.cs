using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw_Grnade : MonoBehaviour
{
    public Rigidbody Grnade_source;
    public int ThrowZ = 30; //遠度
    public int ThrowY = 2; //高度
    public AudioClip Throw_Sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Rigidbody Grnade = Instantiate(Grnade_source, transform.position, transform.rotation);
            Grnade.velocity = transform.TransformDirection(new Vector3(0, ThrowY, ThrowZ)); // 賦予Rigidbody一個速度,一個投擲的力量
            GetComponent<AudioSource>().PlayOneShot(Throw_Sound); // 投擲出去的聲音
        }
    }
}
