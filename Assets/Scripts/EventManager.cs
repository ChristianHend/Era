using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public bool isVisible = false;

    private bool currentlyVisible = false;
    // Start is called before the first frame update
    
    void Start()
    {
        foreach (SpriteRenderer renderer in transform.GetComponentsInChildren<SpriteRenderer>())
        {
            renderer.enabled = isVisible;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isVisible != currentlyVisible)
        {
            foreach (SpriteRenderer renderer in transform.GetComponentsInChildren<SpriteRenderer>())
            {
                renderer.enabled = isVisible;
            }

            currentlyVisible =  isVisible;
        }
    }

    public void Trigger(Func<bool> f, GameObject go)
    {
        f();
        go.GetComponent<SpriteRenderer>().color = Color.yellow;
        Debug.Log("Event triggered for: "+ go.name);
    }
}
