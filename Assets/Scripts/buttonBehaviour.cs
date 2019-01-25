using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonBehaviour : MonoBehaviour
{
   public void sceneLoader(int sceneIndex)
    {
        Debug.Log("Biceps Videos Scene Will be bringed here");
        SceneManager.LoadScene(sceneIndex);
    }
}
