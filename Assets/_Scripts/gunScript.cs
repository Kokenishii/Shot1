using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class gunScript : MonoBehaviour {
    public GameObject projectilePrefab;
    public Vector3 projectileDirection;
    public float force;
    bool OneShot = false;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1.0f;
        Time.fixedDeltaTime = Time.timeScale * 0.005f;
        OneShot = true;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        // GameObject theGun = GameObject.Find("Gun");
        //TEST
        if (Input.GetKey(KeyCode.Space))
        {

            EditorSceneManager.LoadScene(0);
        }
        //TEST

        if (Input.GetMouseButtonUp(0)&&OneShot==true)
        {
            
            Vector3 mousePoint = Input.mousePosition;
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(mousePoint);
            Vector3 projectileDirection = targetPosition - transform.position;
            projectileDirection.z = 0;
          //  Debug.Log(projectileDirection.x + "," + projectileDirection.y);

            GameObject projectileCreated = Instantiate(projectilePrefab) as GameObject;
         
            Rigidbody2D projectileBody = projectileCreated.GetComponent<Rigidbody2D>();

          
          projectileBody.AddForce(new Vector2(force * projectileDirection.x/projectileDirection.magnitude, force * projectileDirection.y / projectileDirection.magnitude), ForceMode2D.Force);

            OneShot = false;
        }
  


    }
       
    }

