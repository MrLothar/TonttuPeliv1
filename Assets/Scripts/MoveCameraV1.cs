using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public Transform cameraPosition;
    void Update()
    {
        transform.position = cameraPosition.position;
    }
}
