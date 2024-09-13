using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public int xCam = 0;
    public int yCam = 5;
    public int zCam = 7;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.transform.position + new Vector3(xCam, yCam, zCam);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(xCam, yCam, zCam);
    }
}
