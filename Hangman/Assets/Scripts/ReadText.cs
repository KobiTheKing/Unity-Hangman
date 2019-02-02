using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * Description: Picks a random word of of the text file or allows the user to input a word
 * Methods: void Awake(), void EnableInputField(), void ReadUserInput(), void ReadTextFile()
 */
public class ReadText : MonoBehaviour {

    //InputField for the word
    [SerializeField]
    #pragma warning disable 0649
    private InputField inputWord;

    //Access 'words.txt'
    [SerializeField]
    #pragma warning disable 0649
    private TextAsset wordListTextFile;

    //Access the 'Word' script
    private Word word;

    //Access the UI canvas groups in the 'GetWord' scene
    [SerializeField]
    #pragma warning disable 0649
    private CanvasGroup typeWordGroup;
    [SerializeField]
    #pragma warning disable 0649
    private CanvasGroup randomWordGroup;

    /*
     * Description: Used for initalization and getting script references
     */
    private void Awake() {
        word = GameObject.FindObjectOfType<Word>();
    }

    /*
     * Description: Enables the Input Field
     */
    public void EnableInputField() {
        //Enables the type word group
        typeWordGroup.alpha = 1f;
        typeWordGroup.blocksRaycasts = true;

        //Disables the random word group
        randomWordGroup.alpha = 0f;
        randomWordGroup.blocksRaycasts = false;

        //Calls the ReadUserInput() method when a word gets inputed
        inputWord.onEndEdit.AddListener(delegate { ReadUserInput(); });
    }

    /*
     * Description: Gets the user input and sends it to the 'Word' script
     */
    private void ReadUserInput() {
        //The word inputed by the user
        string tempWord = inputWord.text;
        //Makes the string lowercase
        tempWord = tempWord.ToLower();
        word.GetWord(tempWord);

        SceneManager.LoadScene("Main");
    }

    /*
     * Description: Picks a random word from 'words.txt'
     */
    public void ReadTextFile() {
        //Disables the type word group
        typeWordGroup.alpha = 0f;
        typeWordGroup.blocksRaycasts = false;

        //Enables the random word group
        randomWordGroup.alpha = 1f;
        randomWordGroup.blocksRaycasts = true;

        //Creates an array and makes each word and element of the list
        string[] eachWord = wordListTextFile.text.Split();

        //Randomly picks a word from the list
        word.GetWord(eachWord[Random.Range(0, eachWord.Length)].ToLower());

        SceneManager.LoadScene("Main");
    }

}
