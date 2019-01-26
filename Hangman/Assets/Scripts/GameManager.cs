using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Description: Manages the flow of the game
 * Methods: void Start(),
 */
public class GameManager : MonoBehaviour {

    private ReadText readText;

    /*
     * Description: Used for initialization and getting script references
     */
    private void Awake() {
        readText = GameObject.FindObjectOfType<ReadText>();
    }

    /*
     * Description: Used after Awake. Use and pass variable references through Start instead of Awake
     */
    private void Start() {
        //Name of the currently open scene
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == "GetWord") {
            if (Word.RandomizeWord) {
                readText.ReadTextFile();
            } else {
                readText.ReadUserInput();
            }
        } else if (currentSceneName == "Main") {

        }
    }

}
