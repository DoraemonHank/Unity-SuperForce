using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Gem : MonoBehaviour
{
    public AudioClip get_sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            Get_Gem_Totle.gem_numbers++;

            Debug.Log(Get_Gem_Totle.gem_numbers);
            GetComponent<AudioSource>().PlayOneShot(get_sound);
            Destroy(gameObject, 0.6f);
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{

       
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        //Debug.Log("sadasdasdasdsa");
    //        Get_Gem_Totle.gem_numbers++;
    //        GetComponent<AudioSource>().PlayOneShot(get_sound);
    //        Destroy(gameObject,0.2f);
    //    }
    //}
}
