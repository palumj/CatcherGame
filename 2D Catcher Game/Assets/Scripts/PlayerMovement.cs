using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject playerObject;

    [Range(0f, 6f)]
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (playerObject.transform.position.x > 8f)
        {
            playerObject.transform.position = new Vector3(8f, -2.5f, 0f);
        }

        if (playerObject.transform.position.x < -8f)
        {
            playerObject.transform.position = new Vector3(-8f, -2.5f, 0f);
        }
    }
}
