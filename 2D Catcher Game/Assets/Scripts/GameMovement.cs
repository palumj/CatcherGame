using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMovement : MonoBehaviour
{
    public GameObject movingObject;

    [Range(0f, 4f)]
    public float speed;

    public float directionChangeChance = 0.3f;

    //instantiate and destroy to create/destroy falling objects
    //use repeating invoke to repeatedly spawn object


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movingObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (Random.value <= directionChangeChance)
        {
            if (Random.value <= directionChangeChance)
            {
                if (Random.value <= directionChangeChance)
                {
                    if (Random.value <= directionChangeChance)
                    {
                        speed *= -1;
                    }
                }
            }
        }

        if (movingObject.transform.position.x < -8f || movingObject.transform.position.x > 8f)
        {
            speed *= -1;
        }
    }
}
