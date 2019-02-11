using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/*
 * Description: Generates and stores the word being guessed
 * Methods: void Awake(), void GetWord(), bool IsLetterInWord(char guess), bool IsGameWon(),
 */
public class Word : MonoBehaviour {

    //The word used in the Hangman game
    private static string currentWord;

    //Array of every character in the word
    private static char[] wordCharacters;

    //An array of all the letter objects
    private static GameObject[] letterObjects = new GameObject[10];

    //True if randomizing word, false if typing word
    private static bool randomizeWord;

    //Number of letters that have been guessed so far
    private int lettersGuessed;

    /*
     * Description: Used for initialization
     */
    private void Awake() {
        
    }

    /*
     * Description: Gets the word and converts it to an array of characters
     * Params: fullWord = the word that has been selected
     */
    public void GetWord(string fullWord) {
        currentWord = fullWord;

        wordCharacters = currentWord.ToCharArray();
    }

    /*
     * Description: Returns true if the letter is in the word
     * Parameters: guess = the letter just guessed
     */
    public bool IsLetterInWord(char guess) {
        int counter = 0;
        bool letterInWord = false;

        foreach (char letter in wordCharacters) {
            if (letter == guess) {
                letterObjects[counter].SetActive(true);
                lettersGuessed++;
                letterInWord = true;
            }

            counter++;
        }

        return letterInWord;
    }

    /*
     * Description: Returns true if the game has been won
     */
    public bool IsGameWon() {
        if (lettersGuessed == wordCharacters.Length) {
            Debug.Log("Won");
            return true;
        }

        return false;
    }

    public static bool RandomizeWord { get => randomizeWord; set => randomizeWord = value; }
    public static string CurrentWord { get => currentWord; set => currentWord = value; }
    public static char[] WordCharacters { get => wordCharacters; set => wordCharacters = value; }
    public static GameObject[] LetterObjects { get => letterObjects; set => letterObjects = value; }
}
