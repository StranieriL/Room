using TMPro;
// librairie 
using UnityEngine;
// cheminement du fichier

public class NewBehaviourScript : MonoBehaviour
// "class" archetype, modele de fonctionnalitée, "monobehaviour" class de base de fonctionnalitée Unity
{
    public TMP_Text messageText;
    public TMP_InputField numberInput;

    private int randomNumber; 

    private void Start()
// appeler un element à un instant clé, "()" dit que c'est une fonction
    {
        ResetGame();
        messageText.text = "Guess The Number...!";
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text) == true)
// permet de tester un boleart [oui ou non] 
        {
            messageText.text = "Ah ah Try again BITCH !";
            numberInput.text = "";
            return;
        }

        if (int.TryParse (numberInput.text, out int playerNumber))
        {
            if (playerNumber == randomNumber)
            {
                messageText.text = "Victory !";
            }
            else if (playerNumber > randomNumber)
            {
                messageText.text = "Try lower...";
            }
            else if (playerNumber < randomNumber)
            {
                messageText.text = "Try greater...";
            }
            // Si PlayerNumber egale à randomNumber
            // Victoire (changer le message, reset le champ texte]
            // Si playerNumber est superieur à randomNumber
            // Annonce "moins"
            // Si playerNumber est inferieur à randomNumber
            // Annonce "plus"
        }
        else
        {
            messageText.text = "A number ! Idiot !";
            // Si playerNumber pas un nombre
           
        }
        numberInput.text = "";
      
// shema pour qu'une fonction envoi plusieurs valeurs

    }
    public void ResetGame()
    {
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("Generate number ; " + randomNumber);
        messageText.text = "Guess The Fucking Number...!";
    }
}
// "{...}" pour indiquer ce qu'il y a dans la class