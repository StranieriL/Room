using TMPro;
using UnityEngine;

public class dialogueplayer : MonoBehaviour
{
    public DialogueAsset dialogueAsset;
    public TMP_Text dialogueText;
    public GameObject dialogueBox;
    //public RectTransform dialogueBox


    private int dialogueLineIndex; 



    private void Start()
    {
        dialogueText.text = dialogueAsset.dialogue[0];
    }

    void Update ()
    {
        if ( Input.GetKeyDown( KeyCode.Return ) )
        {
            dialogueLineIndex += 1;
            //dialogueLineIndex = dialogueLineIndex + 1
            //dialogueLineIndex++
            //meme fonction

            if( dialogueLineIndex < dialogueAsset.dialogue.Length )
            {
                dialogueText.text = dialogueAsset.dialogue[dialogueLineIndex];
            }
            else
            {
                dialogueBox.gameObject.SetActive(false);
            }

        }
    }
}



/*
 * 
 * [0] = "Text 1"
 * [1] = "Text 2"
 * [2] = "Text 3"
 * 
 * Length = 3
 * 
 *  3
 * 
 */
