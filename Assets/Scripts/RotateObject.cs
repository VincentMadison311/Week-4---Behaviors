using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateObject : MonoBehaviour
{

    [SerializeField] float RotateSpeed;
    [SerializeField] Vector3 RotateDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(RotateDirection * RotateSpeed);
    }
}
