using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenuFromMapSelecter : MonoBehaviour
{
    public void BackToMenuFromMapSelect()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    
}
