using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignPost : ActionItem {

    public string[] dialogNames;
    public string name;

    public override void Interact(GameObject interactWithObject)
    {
        DialogueSystem.Instance.AddNewDialog(this.dialogNames, this.name);
        Debug.Log("Interacting with Sign Post");
    }

    public override float StopDistance()
    {
        return 2f;
    }
}
