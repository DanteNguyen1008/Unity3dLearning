using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour {

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        this.Interact(other.gameObject);
    }

    public virtual void Interact(GameObject interactWithObject)
    {
        Debug.Log("Interating with base class!");
    }

    public virtual float StopDistance()
    {
        // default value
        return 2.5f;
    }
}
