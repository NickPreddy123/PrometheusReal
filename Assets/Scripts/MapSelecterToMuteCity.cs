using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSelecterToMuteCity : MonoBehaviour
{
    public void MapSelectToMute()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
}

