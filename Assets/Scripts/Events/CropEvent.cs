using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropEvent : MonoBehaviour
{
    private EventManager eventManager;

    private bool playerInbounds = false;
    // Start is called before the first frame update
    void Start()
    {
        eventManager = GameObject.Find("Events").GetComponent<EventManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInbounds && Input.GetKeyDown(KeyCode.E))
        {
            eventManager.Trigger(Test, gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        playerInbounds = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        playerInbounds = false;
    }

    private bool Test()
    {
        return true;
    }
}