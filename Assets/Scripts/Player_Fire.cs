using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Fire : MonoBehaviour
{
    //public GameObject bullet;
    public GameObject Fire_Particle; // 火花
    public AudioClip Fire_Sound; //聲音來源

    public Rigidbody bullet;
    public int ThrowZ = 30; //遠度
    public int ThrowY = 2; //高度


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Instantiate(bullet, transform.position, transform.rotation); //動態生成一個物件(子彈)

            Rigidbody Grnade = Instantiate(bullet, transform.position, transform.rotation);
            Grnade.velocity = transform.TransformDirection(new Vector3(0, ThrowY, ThrowZ)); // 賦予Rigidbody一個速度,一個投擲的力量

            Instantiate(Fire_Particle, transform.position, transform.rotation); //動態生成一個物件(火焰)
            GetComponent<AudioSource>().PlayOneShot(Fire_Sound);
        }
    }
}
