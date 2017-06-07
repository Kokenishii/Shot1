using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slomoScript : MonoBehaviour {
    bool timeSlow;
   public float SlowSeconds=0.1f;
	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        Time.fixedDeltaTime = Time.timeScale * 0.005f;
    }
	
	// Update is called once per frame
	void Update ()
    {
       // Debug.Log(Time.timeScale);
       Time.fixedDeltaTime = Time.timeScale * 0.005f;
		if(timeSlow)
        {
            Time.timeScale = Mathf.Lerp(Time.timeScale,0.05f,0.4f);
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 4.9f, 0.05f);
            StartCoroutine(turnFalse());

        }
        else
        {
            //Time.timeScale = 1f;
            Time.timeScale = Mathf.Lerp(Time.timeScale, 1f, 0.4f);
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 5f, 0.05f);
        }
	}
    void OnTriggerEnter2D(Collider2D enemy)
    {
        if(enemy.gameObject.tag=="enemy")
        { timeSlow = true;
        }
    }
    void OnTriggerExit2D()
    {
       // timeSlow = false;
    }
    IEnumerator turnFalse()
    {

        yield return new WaitForSeconds(SlowSeconds);
        timeSlow = false;
    }
}
