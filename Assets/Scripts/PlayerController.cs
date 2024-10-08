using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float horizontalInput;
    public float turnSpeed;
    public float fowardInpunt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInpunt = Input.GetAxis("Vertical");
        //move the vehicule
        transform.Translate(Vector3.forward * Time.deltaTime * speed* fowardInpunt);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "EndPoint")
        {
              SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
