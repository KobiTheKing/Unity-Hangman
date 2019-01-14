using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Description: Generates and stores the word being guessed
 * Methods: void Awake(), void Start(), void TypeWord()
 */
public class Word : MonoBehaviour {

    //True if randomizing word, false if typing word
    private static bool randomizeWord;

    //True if in the 'GetWord' scene
    private static bool inGetWordScene;

    /*
     * Description: Used for initialization
     */
    void Awake() {
        //Default values
        RandomizeWord = true;
        InGetWordScene = false;
    }

    /*
     * Description: Called when object is created (after 'Awake')
     */
    private void Start() {
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
        Debug.Log("type");
    }

    /*
     * Description: Randomly generated a word for the game
     */
    private void RandomWord() {
        Debug.Log("random");
    }

    public static bool RandomizeWord { get => randomizeWord; set => randomizeWord = value; }
    public static bool InGetWordScene { get => inGetWordScene; set => inGetWordScene = value; }
}
