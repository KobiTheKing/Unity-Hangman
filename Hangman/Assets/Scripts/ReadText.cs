using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Description: Picks a random word of of the text file or allows the user to input a word
 * Methods: 
 */
public class ReadText : MonoBehaviour {

    //InputField for the word
    public InputField inputWord;

    /*
     * Description: Gets the user input and sends it to the 'Word' script
     */
    public void ReadUserInput() {
        string tempWord = inputWord.text;
        tempWord = tempWord.ToLower();
        Word.CurrentWord = tempWord;
        Debug.Log(Word.CurrentWord);
    }

}
