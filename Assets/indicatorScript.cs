using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indicatorScript : MonoBehaviour {
    LineRenderer indicator;
    Vector3 mouseWorldPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        indicator = gameObject.GetComponent<LineRenderer>();

        //Debug.Log(Input.mousePosition.x + "," + Input.mousePosition.y + "," + Input.mousePosition.z);

        mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPoint.z = gameObject.transform.position.z;
        if (Input.GetMouseButton(0))
        {

            indicator.SetPosition(0, gameObject.transform.position);
            indicator.SetPosition(1, mouseWorldPoint);

        }
        else
        {
            indicator.SetPosition(0, gameObject.transform.position);
            indicator.SetPosition(1, gameObject.transform.position);
        }

        Debug.Log(mouseWorldPoint.x + "," + mouseWorldPoint.y);
    }
}
