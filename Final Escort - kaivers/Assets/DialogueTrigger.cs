using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogueTrigger : MonoBehaviour
{

public Dialogue dialogue;

public void TriggerDialogue(){ //best way to do this would be to use a Singleton pattern

    FindAnyObjectByType<DialogueManager>().StartDialogue(dialogue);

}


}
