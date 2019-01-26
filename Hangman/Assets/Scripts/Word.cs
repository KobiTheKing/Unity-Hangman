using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/*
 * Description: Generates and stores the word being guessed
 * Methods: void GetWord()
 */
public class Word : MonoBehaviour {

    //The word used in the Hangman game
    private static string currentWord;

    //Array of every character in the word
    private static char[] wordCharacters;

    //True if randomizing word, false if typing word
    private static bool randomizeWord;

    /*
     * Description: Gets the word and converts it to an array of characters
     * Params: fullWord = the word that has been selected
     */
    public void GetWord(string fullWord) {
        currentWord = fullWord;

        wordCharacters = currentWord.ToCharArray();
    }

    public static bool RandomizeWord { get => randomizeWord; set => randomizeWord = value; }
    public static string CurrentWord { get => currentWord; set => currentWord = value; }
}
