using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Dialogue {

    public string name; //name of NPC 

    [TextArea(3, 10)] //min 3 sentences, max 10 sentences.
    public string[] sentences; //dialogue 

}
