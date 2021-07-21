using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_MapCam : MonoBehaviour
{
    public GameObject MapCam;
    public GameObject Life_Gem_UI;
    public AudioClip sound;
    private bool keyState = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            //Debug.Log("fuck");

            GetComponent<AudioSource>().PlayOneShot(sound);
            if(keyState == false)
            {
                MapCam.SetActive(true);
                Life_Gem_UI.SetActive(false);
                keyState = true;
            }
            else
            {
                MapCam.SetActive(false);
                Life_Gem_UI.SetActive(true);
                keyState = false;
            }
        }
    }
}
