using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Description: Sets up the game
 * Methods: void EnableLetterSpaces(GameObject[] letterSpaces), void SpawnLetters(),
 */
public class SetupGame : MonoBehaviour {

    /*
     * Description: Enables the proper letter spaces
     * Params: letterSpaces = an array of all the letter spaces in order
     */
    public void EnableLetterSpaces(GameObject[] letterSpaces) {
        //The total amount of letters in the word
        int totalLetters = Word.WordCharacters.Length;
        Debug.Log(totalLetters);

        //Enables only enough letter spaces to fit the size of the word
        for (int counter = 0; counter < totalLetters; counter++) {
            letterSpaces[counter].SetActive(true);
        }
    }

    /*
     * Description: Spawns each letter at the correct location and disables them to start
     */
    public void SpawnLetters(GameObject[] letterSpawnLocations) {
        //The parent of all the letters in the scene
        GameObject letterParent = GameObject.Find("Letters");

        //Loops through each letter in the word and spawns them
        for (int counter = 0; counter < Word.WordCharacters.Length; counter++) {
            //GameObject letterPrefabClone = GameObject.FindGameObjectWithTag(Word.WordCharacters[counter]);
            Debug.Log(Word.WordCharacters[counter].ToString());
            //Instantiates the letter
            GameObject letterPrefabClone = Instantiate(GameObject.FindGameObjectWithTag(Word.WordCharacters[counter].ToString()), letterParent.transform);

            //Moves the letter to the proper position
            letterPrefabClone.transform.position = letterSpawnLocations[counter].transform.position;
        }
    }

}
