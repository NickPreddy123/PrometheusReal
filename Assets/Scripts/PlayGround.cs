using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGround : MonoBehaviour
{
    public void TestMapSelect()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
   
}
