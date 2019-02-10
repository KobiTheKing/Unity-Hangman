using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Description: Controls the character being hung
 * Methods: void Awake(), void EnableNextPiece(), bool IsGameLost(),
 */
public class Character : MonoBehaviour {

    //Contains all the pieces that make up the character
    [SerializeField]
    private GameObject[] characterPieces;

    //The amount of character pieces that have been placed so far
    private int piecesUsed;

    /*
     * Description: Used for initialization
     */
    private void Awake() {
        piecesUsed = 0;
    }

    /*
     * Description: Enables the next piece in the array of pieces
     */
    public void EnableNextPiece() {
        characterPieces[piecesUsed].SetActive(true);
        piecesUsed++;
    }

    /*
     * Description: Returns true if the game has been lost
     */
    public bool IsGameLost() {
        if (piecesUsed == 7) {
            Debug.Log("Lost");
            return true;
        }

        return false;
    }

}
