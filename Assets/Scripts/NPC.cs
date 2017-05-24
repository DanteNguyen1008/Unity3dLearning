using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable {

    public string[] dialogLines;
    public string name;

    public override void Interact(GameObject interactWithObject)
    {
        if (interactWithObject.tag.Equals("Player"))
        {
            var basicBehavior = interactWithObject.GetComponent<BasicBehaviour>();
            if(basicBehavior != null)
            {
                basicBehavior.IsActive = false;
            }

            var moveBehavior = interactWithObject.GetComponent<MoveBehaviour>();
            if (moveBehavior != null)
            {
                moveBehavior.IsActive = false;
            }

            DialogueSystem.Instance.AddNewDialog(this.dialogLines, this.name);
            Debug.Log("Interacting with NPC");
        }
    }

    public override float StopDistance()
    {
        return 2.5f;
    }
}
