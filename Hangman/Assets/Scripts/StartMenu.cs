using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/*
 * Description: Controls the start menu
 * Methods: void Awake(), void TypeWord(), void RandomWord()
 */
public class StartMenu : MonoBehaviour {

    //Access 'Word' script
    private Word word;

    /*
     * Used for initialization and getting script references
     */
    private void Awake() {
        word = GameObject.FindObjectOfType<Word>();
    }

    /*
     * Description: Called of the type word button is clicked. Allows the user to chose the word for the hangman game
     */
    public void TypeWord() {
        Word.RandomizeWord = false;

        SceneManager.LoadScene("GetWord");
    }

    /*
     * Description: Called of the random word button is clicked. Randomly chooses the word for the hangman game
     */
    public void RandomWord() {
        Word.RandomizeWord = true;

        SceneManager.LoadScene("GetWord");
    }

}
