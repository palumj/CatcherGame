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

    void Update()
    {
        movingObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {//A series of if statements is used because it seemed to work best for smoother movement
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

        //Bounds of movement for the dropping object
        if (movingObject.transform.position.x < -8f || movingObject.transform.position.x > 8f)
        {
            speed *= -1;
        }
    }
}
