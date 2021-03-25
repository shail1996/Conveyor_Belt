using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingObject : MonoBehaviour
{
    [SerializeField] private GameObject[] cubes;
    [SerializeField] Transform initialPosition;
    
    // Random number variables
    private float randomFloat;
    private int randomInt;

    // Time variables
    private float time, delayTime;

    void Start()
    {
        time = 0.0f;
        delayTime = 2.5f;
        initializePrefab();
    }

    void Update()
    {
        time = time + 1.0f * Time.deltaTime;

        if (time >= delayTime && delayTime > 0.2f)
        {
            delayTime -= 0.1f;
            time = 0.0f;
            initializePrefab();
        }

    }

    private void initializePrefab()
    {
        randomFloat = Random.Range(-0.5f, 0.5f);
        randomInt = Random.Range(0, 2);

        Instantiate(cubes[randomInt], new Vector3(initialPosition.position.x, initialPosition.position.y, randomFloat), initialPosition.rotation);
    }
}
