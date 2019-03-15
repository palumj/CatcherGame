using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingMovement : MonoBehaviour
{
    public GameObject movingObject;
    public GameObject fallingObject;
    public GameObject destroyCollider;

    [Range(0f, 3f)]
    public float speed;

    public void SpawnObject()
    {
        Instantiate(fallingObject, movingObject.transform.position, Quaternion.identity);
    }

    public void Start()
    {
        InvokeRepeating("SpawnObject", 3, 3);
    }
}
