using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileTestScript : MonoBehaviour {
    //  public GameObject theGun;
    // Use this for initialization
    GameObject theGun;
    public GameObject particleKill;
    void Start () {
  theGun =  GameObject.Find("Gun");
      transform.position =  theGun.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 projectileDirection = theGun.GetComponent<gunScript>().projectileDirection;
      
	}
    void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.gameObject.tag == "enemy")
        {
            particleKill.gameObject.SetActive(true);
        }
    }
    void OnTriggerExit2D()
    {
        //StartCoroutine(DestorySelf());

    }
    IEnumerator DestorySelf()
    {

        yield return new WaitForSeconds(3);
        particleKill.gameObject.SetActive(false);
    }
}
