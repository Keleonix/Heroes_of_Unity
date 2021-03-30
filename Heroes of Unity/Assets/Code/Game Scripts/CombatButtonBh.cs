using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CombatButtonBh : MonoBehaviour
{

    public void StartGame()
    {
        // this object was clicked - do something
        SceneManager.LoadScene("Forest1Scene");
    }

}
