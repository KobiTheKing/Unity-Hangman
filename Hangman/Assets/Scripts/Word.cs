using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/*
 * Description: Generates and stores the word being guessed
 * Methods: void Awake(), void Start(), void TypeWord(), string GetWord()
 */
public class Word : MonoBehaviour {

    //The word used in the Hangman game
    private static string currentWord;

    //True if randomizing word, false if typing word
    private static bool randomizeWord;

    //True if in the 'GetWord' scene
    private static bool inGetWordScene;

    //Access the 'ReadText' script
    private ReadText readText;

    //Access the UI canvas groups in the 'GetWord' scene
    [SerializeField]
    private CanvasGroup typeWordGroup;
    [SerializeField]
    private CanvasGroup randomWordGroup;

    /*
     * Description: Used for initialization
     */
    void Awake() {
        readText = GameObject.FindObjectOfType<ReadText>();
    }

    /*
     * Description: Called when object is created (after 'Awake')
     */
    private void Start() {
        //Prevents 'RandomWord()' and 'TypeWord()' from being called when not in the 'GetWord' scene
        if (InGetWordScene) {
            if (RandomizeWord) {
                RandomWord();
            } else {
                TypeWord();
            }
        }
    }

    /*
     * Description: Allows the user to type in a word for the game
     */
    private void TypeWord() {
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
    private void RandomWord() {
        //Disables the type word group
        typeWordGroup.alpha = 0f;
        typeWordGroup.blocksRaycasts = false;

        //Enables the random word group
        randomWordGroup.alpha = 1f;
        randomWordGroup.blocksRaycasts = true;

        readText.ReadTextFile();
    }

    public string GetWord(string fullWord) {

    }

    public static bool RandomizeWord { get => randomizeWord; set => randomizeWord = value; }
    public static bool InGetWordScene { get => inGetWordScene; set => inGetWordScene = value; }
    public static string CurrentWord { get => currentWord; set => currentWord = value; }
}
