using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// Dialogue manager script that handles the starting, stopping, next sentence, character typing and UI implementation of the dialogue.
/// </summary>

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    private Queue<string> sentences;

    private void Awake()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue) // Method that starts the dialogue and shows the text box, queues the next sentence and displays the next one on click of the continue button.
    {
        Debug.Log("Start of Interaction.");
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    private void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    private IEnumerator TypeSentence(string sentence) // Individually types out each character in the dialogue box.
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.01f);
        }
    }

    private void EndDialogue() // Animates the text box to move away and starts the Tracker Delay coroutine
    {
        Debug.Log("End of Interaction.");
    }
}
