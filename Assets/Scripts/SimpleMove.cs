using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    bool move = false;
    // Update is called once per frame

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            move = !move;
        }
        if (move)
        {
            Transform t = GetComponent<Transform>();
            t.position += new Vector3(0.025f, 0, 0);
        }
    }
}