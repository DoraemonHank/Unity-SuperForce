using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Healthpack : MonoBehaviour
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
        if (other.gameObject.tag == "Player" && Get_Gem_Totle.life_num < 10)
        {
            Get_Gem_Totle.life_num++;
            Debug.Log(Get_Gem_Totle.life_num);

            //Debug.Log(Get_Gem_Totle.healthpack_numbers);
            GetComponent<AudioSource>().PlayOneShot(get_sound);
            Destroy(gameObject, 0.45f);
        }
    }
}
