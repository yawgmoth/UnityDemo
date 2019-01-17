using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlHovercraft : MonoBehaviour
{

    public Waypoint target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float sgn = Mathf.Sign(- Input.GetAxis("Vertical"));
        if (Mathf.Abs(Input.GetAxis("Vertical")) < 0.001) sgn = 0;
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 100*sgn, 0));

        sgn = Mathf.Sign(Input.GetAxis("Horizontal"));
        if (Mathf.Abs(Input.GetAxis("Horizontal")) < 0.001) sgn = 0;
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(100 * sgn, 0, 0));

        float dir = 0;
        dir = Mathf.Clamp((Input.mousePosition.x - Screen.width / 2)/100, -3, 3);
        transform.rotation = Quaternion.Euler(0, dir, 0) * transform.rotation;
        

    }
}
