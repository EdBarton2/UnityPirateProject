using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBehaviour : MonoBehaviour
{
    public AudioClip cannonShot;
    public ParticleSystem smoke;
    public GameObject ui;
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
        if(other.tag == "Player")
        {
            ShowUI();
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("F");
                ShootCannon();
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
    public void ShootCannon()
    {
        smoke.Play();
        gameObject.GetComponent<AudioSource>().PlayOneShot(cannonShot);
    }
}
