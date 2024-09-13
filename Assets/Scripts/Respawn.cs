using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Respawn : MonoBehaviour
{
    public float threshold;

    private void FixedUpdate()
    {
        if(transform.position.y < threshold || Input.GetKeyDown(KeyCode.R))
        {
            transform.position = new Vector3(0f,2f, 0f);
            transform.rotation = new Quaternion(0f ,0f,0f, 0f);
        }
    }

}

