using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    public Waypoint next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ControlHovercraft hover = other.gameObject.GetComponent<ControlHovercraft>();
        if (hover != null)
        {
            if (hover.target == this)
            {
                hover.target = next;
                next.GetComponent<MeshRenderer>().material.color = Color.red;
                GetComponent<MeshRenderer>().material.color = Color.white;
                Debug.Log("next target!");
            }
        }
    }
}
