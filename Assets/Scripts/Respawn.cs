using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Respawn : MonoBehaviour
{
    public float threshold;

    private void Update()
    {
        if(transform.position.y < threshold || Input.GetKeyDown(KeyCode.K))
        {
            transform.position = new Vector3();
            transform.rotation = new Quaternion();
        }
    }

}

