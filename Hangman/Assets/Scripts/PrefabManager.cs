using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Description: Accesses all the prefabs in the game
 * Methods: void Awake(), GameObject GetPrefab(string prefabName),
 */
public class PrefabManager : MonoBehaviour {

    //Letter prefabs
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public GameObject f;
    public GameObject g;
    public GameObject h;
    public GameObject i;
    public GameObject j;
    public GameObject k;
    public GameObject l;
    public GameObject m;
    public GameObject n;
    public GameObject o;
    public GameObject p;
    public GameObject q;
    public GameObject r;
    public GameObject s;
    public GameObject t;
    public GameObject u;
    public GameObject v;
    public GameObject w;
    public GameObject x;
    public GameObject y;
    public GameObject z;

    /*
     * Description: Used for initialization and getting script references
     */
    private void Awake() {
        
    }

    /*
     * Description: Returns a prefab based on a given prefab name
     * Params: prefabName = Name of the prefab being searched for
     */
    public GameObject GetPrefab(string prefabName) {
        return this.GetType().GetField(prefabName).GetValue(this);
    }
}
