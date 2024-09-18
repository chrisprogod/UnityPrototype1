using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public float threshold;

    private void Update()
    {
        if(transform.position.y < threshold || Input.GetKeyDown(KeyCode.R))
        {
               SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}

