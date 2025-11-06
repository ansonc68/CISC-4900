using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapChangeManager : MonoBehaviour
{
    // Change to jungle map
    public void ChangeToJungle()
    {
        SceneManager.LoadScene("Jungle");
    }

    // Change to moon map
    public void ChangeToMoon()
    {
        SceneManager.LoadScene("Moon");
    }

    // Change to desert map
    public void ChangeToDesert()
    {
        SceneManager.LoadScene("Desert");
    }
}
