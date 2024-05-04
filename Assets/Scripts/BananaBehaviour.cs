using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class BananaBehaviour : MonoBehaviour
{
    public GameObject ui;
    public AudioClip eatSound;
    // Start is called before the first frame update
    void Start()
    {
        HideUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            ShowUI();
            if (Input.GetKeyDown(KeyCode.F))
            {
                EatBanana();
            }


        }
    }
    private void OnTriggerExit(Collider other)
    {

        HideUI();
    }
    public void HideUI()
    {
        ui.SetActive(false);
    }
    public void ShowUI()
    {
        ui.SetActive(true);
    }
    public void EatBanana()
    {
        
        gameObject.GetComponent<AudioSource>().PlayOneShot(eatSound);
        gameObject.SetActive(false);
        gameObject.GetComponent<BoxCollider>().enabled = false;
        HideUI();
    }
}
