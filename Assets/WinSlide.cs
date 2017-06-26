using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinSlide : MonoBehaviour {
   public Slider countdown;
	// Use this for initialization
	void Start () {
       countdown.value = 0;
	}
	
	// Update is called once per frame
	void Update () {
      countdown.value += Time.deltaTime/3;
        StartCoroutine(NextScene());

    }

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(3.1f);
      SceneManager.LoadScene(Application.loadedLevel + 1);
    }
}
