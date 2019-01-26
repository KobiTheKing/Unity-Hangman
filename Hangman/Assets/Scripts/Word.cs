using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/*
 * Description: Generates and stores the word being guessed
 * Methods: void Awake(), void Start(), void TypeWord(), void GetWord()
 */
public class Word : MonoBehaviour {

    //The word used in the Hangman game
    private static string currentWord;

    //Array of every character in the word
    private static char[] wordCharacters;

    //True if randomizing word, false if typing word
    private static bool randomizeWord;

    //Access the 'ReadText' script
    private ReadText readText;

    //Access the UI canvas groups in the 'GetWord' scene
    [SerializeField]
    private CanvasGroup typeWordGroup;
    [SerializeField]
    private CanvasGroup randomWordGroup;

    /*
     * Description: Used for initialization and getting script references
     */
    void Awake() {
        readText = GameObject.FindObjectOfType<ReadText>();
    }

    /*
     * Description: Allows the user to type in a word for the game
     */
    public void TypeWord() {
        //Enables the type word group
        typeWordGroup.alpha = 1f;
        typeWordGroup.blocksRaycasts = true;

        //Disables the random word group
        randomWordGroup.alpha = 0f;
        randomWordGroup.blocksRaycasts = false;
    }

    /*
     * Description: Randomly generated a word for the game
     */
    public void RandomWord() {
        //Disables the type word group
        typeWordGroup.alpha = 0f;
        typeWordGroup.blocksRaycasts = false;

        //Enables the random word group
        randomWordGroup.alpha = 1f;
        randomWordGroup.blocksRaycasts = true;

        readText.ReadTextFile();
    }

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
