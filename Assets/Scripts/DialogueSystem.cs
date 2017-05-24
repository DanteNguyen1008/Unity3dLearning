using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour {
    public static DialogueSystem Instance { get; set; }
    public List<string> dialogLines = new List<string>();
    public string name;
    public GameObject dialogObject;

    Button continueButton;
    Text dialogText, nameText;
    int dialogIndex;

    void Awake()
    {
        this.continueButton = this.dialogObject.transform.FindChild("Continue").GetComponent<Button>();
        this.dialogText = this.dialogObject.transform.FindChild("Text").GetComponent<Text>();
        this.nameText = this.dialogObject.transform.FindChild("Name").GetChild(0).GetComponent<Text>();

        this.continueButton.onClick.AddListener(delegate {
            ContinueDialog();
        });

        this.dialogObject.SetActive(false);

        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        } 
        else
        {
            Instance = this;
        }
    }

    public void AddNewDialog(string[] lines, string name)
    {
        this.dialogIndex = 0;
        this.name = name;
        this.dialogLines.Clear();
        this.dialogLines.AddRange(lines);

        Debug.Log("New dialog lines count " + this.dialogLines.Count + " name " + this.name);
        this.CreateDialog();
    }

    public void CreateDialog()
    {
        this.dialogText.text = dialogLines[this.dialogIndex];
        this.nameText.text = this.name;
        this.dialogObject.SetActive(true);
    }

    public void ContinueDialog()
    {
        this.dialogIndex++;
        if (this.dialogIndex >= this.dialogLines.Count)
        {
            this.dialogObject.SetActive(false);
            GameController.Instance.EnablePlayerMovement();
        }
        else
        {
            this.dialogText.text = this.dialogLines[this.dialogIndex];
        }
    }
}
