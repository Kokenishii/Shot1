using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class countDeath : MonoBehaviour {
    public int enemyNumber;
    public int enemyKilled;
    public GameObject nextLevelUI;
    // Use this for initialization
    void Start () {
      
        enemyKilled = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(enemyKilled>=enemyNumber)
        {
            nextLevelUI.SetActive(true);
          //  StartCoroutine(ReStart());

        }
	}

   // IEnumerator ReStart()
   // {

       // yield return new WaitForSeconds(2);
       // SceneManager.LoadScene(0);
    //}
}
