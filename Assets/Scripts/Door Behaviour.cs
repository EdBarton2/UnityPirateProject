using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    public GameObject ui;
    public AudioClip doorOpening;
    public Animator animator;
       
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
            if (Input.GetKeyDown(KeyCode.F) && animator.GetBool("State") == false)
            {

                animator.SetBool("State", true);

            }
            if (Input.GetKeyDown(KeyCode.E) && animator.GetBool("State") == true)
            {
                animator.SetBool("State", false);
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
}
