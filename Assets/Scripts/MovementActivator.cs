using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator : MonoBehaviour

{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] bool Rotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


     
    }
    void OnTriggerEnter(Collider Door)
    {

        if (Rotate)
            objectToActivate.GetComponent<RotateObject>().enabled = true;
        else
            objectToActivate.GetComponent<MoveObject>().enabled = true;
    }
    void OnTriggerExit(Collider Door)
    {
        if(Rotate)
            objectToActivate.GetComponent<RotateObject>().enabled = false;
        else
            objectToActivate.GetComponent<MoveObject>().enabled = false;
    }
}
