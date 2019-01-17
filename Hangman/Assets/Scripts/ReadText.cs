using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * Description: Picks a random word of of the text file or allows the user to input a word
 * Methods: void Awake(), void ReadUserInput(), void ReadTextFile()
 */
public class ReadText : MonoBehaviour {

    //InputField for the word
    [SerializeField]
    private InputField inputWord;

    //Access 'words.txt'
    [SerializeField]
    private TextAsset wordListTextFile;

    //Access the 'Word' script
    private Word word;

    /*
     * Description: Used for initalization
     */
    private void Awake() {
        word = GameObject.FindObjectOfType<Word>();
    }

    /*
     * Description: Gets the user input and sends it to the 'Word' script
     */
    public void ReadUserInput() {
        string tempWord = inputWord.text;
        //Makes the string lowercase
        tempWord = tempWord.ToLower();
        Word.CurrentWord = tempWord;
        Debug.Log(Word.CurrentWord);

        SceneManager.LoadScene("Main");
    }

    /*
     * Description: Picks a random word from 'words.txt'
     */
    public void ReadTextFile() {
        string wholeTxtFileAsOneString = wordListTextFile.text;

        //Creates a list and makes each word and element of the list
        List<string> eachWord = new List<string>();
        eachWord.AddRange(wholeTxtFileAsOneString.Split("\n"[0]));

        //Randomly picks a word from the list
        word.GetWord(eachWord[Random.Range(0, eachWord.Count)].ToLower());
        Debug.Log(Word.CurrentWord);

        SceneManager.LoadScene("Main");
    }

}
