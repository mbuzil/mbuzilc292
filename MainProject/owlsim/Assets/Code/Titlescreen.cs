using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Titlescreen : MonoBehaviour
{
    public void loadA()
    {
        SceneManager.LoadScene(1);
    }

    public void loadB()
    {
        SceneManager.LoadScene(2);
    }
}
