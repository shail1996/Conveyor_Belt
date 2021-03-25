using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private float speed = 0.01f;

    void Update()
    {
        this.gameObject.transform.Translate(speed, 0, 0);
        if (this.gameObject.transform.position.x > 7)
        {
            Destroy(this.gameObject);
        }

        if (Input.GetKeyDown("space"))
        {
            //Debug.Log(this.gameObject.name);
            if(this.gameObject.name == "Blue(Clone)" && this.gameObject.transform.position.x > 2.5 && this.gameObject.transform.position.x < 5)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
