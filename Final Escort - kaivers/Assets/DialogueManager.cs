using UnityEngine;
using System.Collections.Generic;
using TMPro;


public class DialogueManager : MonoBehaviour
{

    public TextMeshProUGUI nameText; 
    public TextMeshProUGUI dialogueText;
 

    private Queue<string> sentences; //FIFO 

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue){
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences){ 
            sentences.Enqueue(sentence); //queue a sentence up
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence(){
        if (sentences.Count == 0){
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue(); //in case we have sentences we still wanna say, we can dequeue them from the list as we want them said 
        dialogueText.text = sentence;
    }


    public void EndDialogue(){
        Debug.Log("End of Convo");
    }

}
