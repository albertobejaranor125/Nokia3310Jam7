using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject dialogBox;
    [SerializeField] TextMeshProUGUI dialogText;
    [SerializeField] float lettersPerSecond;
    public static DialogueManager Instance { get; private set; }
    void Awake()
    {
        Instance = this;
    }
    int currentLine = 0;
    Dialogue dialogue;
    bool isTyping;
    public IEnumerator ShowDialogue(Dialogue dialogue)
    {
        yield return new WaitForEndOfFrame();
        this.dialogue = dialogue;
        dialogBox.SetActive(true);
        StartCoroutine(TypeDialogue(dialogue.Lines[0]));
    }
    public IEnumerator TypeDialogue(string line)
    {
        isTyping = true;
        dialogText.text = "";
        foreach (var letter in line.ToCharArray())
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(1f / lettersPerSecond);
        }
        isTyping = false;
    }
    private void Update()
    {
        if (dialogBox.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Z) && !isTyping)
            {
                currentLine++;
                if (currentLine < dialogue.Lines.Count)
                {
                    StartCoroutine(TypeDialogue(dialogue.Lines[currentLine]));
                }
                else
                {
                    currentLine = 0;
                    dialogBox.SetActive(false);
                }
            }
        }
    }
}
