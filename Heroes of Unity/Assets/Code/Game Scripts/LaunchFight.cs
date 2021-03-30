using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Test_HoU;
using UnityEngine.SceneManagement;


public class LaunchFight : MonoBehaviour
{
    Program prog;

    void Awake()
    {
        // Debug.Log("Awake");
    }

    // called first
    void OnEnable()
    {
        // Debug.Log("OnEnable called");
    }

    // called second
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Debug.Log("OnSceneLoaded: " + scene.name);
        // Debug.Log(mode);
    }

    // called third
    void Start()
    {
        /*GameObject charac = new GameObject();
        Sprite sp = Resources.Load<Sprite>("Images/Character_3_sprite");

        charac.transform.SetParent(GameObject.FindGameObjectWithTag("Map").transform, false);
        charac.transform.localPosition = Vector3.zero;
        charac.SetActive(true);
        Image im = charac.AddComponent<Image>();
        im.sprite = sp;

        CharacterObject characObj = charac.AddComponent<CharacterObject>();
        characObj.CharacInit(charac, 3);
        characObj.obj.SetActive(true);*/

        CharacterObject characObj = GameObject.FindGameObjectWithTag("Map").AddComponent<CharacterObject>();
        characObj.CharacInit(GameObject.FindGameObjectWithTag("Map"), 3);

        Debug.Log(characObj);

        /*prog = (Program)ScriptableObject.CreateInstance(typeof(Program));
        prog.Main();*/
    }

    // called when the game is terminated
    void OnDisable()
    {
        // Debug.Log("OnDisable");
    }
}

