using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : Interactable {

    public override void Interact(GameObject interactWithObject)
    {
        Debug.Log("Interacting with Item");
    }

    public override float StopDistance()
    {
        return 2f;
    }
}
