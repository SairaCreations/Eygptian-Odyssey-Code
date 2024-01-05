using UnityEngine;

using UnityEngine.SceneManagement;

using System;

 

public class Collider2 : MonoBehaviour

{

    public Rigidbody2D rigidbody2D;

    public UnityEngine.SceneManagement.Scene scene;

    public string sceneNumber;

    public int whichScene;

    public int removeGravityNumber;

   

   

 

    void Awake(){

        rigidbody2D = GetComponent<Rigidbody2D>();

        scene = SceneManager.GetActiveScene();

        sceneNumber = scene.name.Trim();

        sceneNumber = sceneNumber.Replace("Level","");

        whichScene = Int32.Parse(sceneNumber);

        removeGravityNumber = whichScene*2;
        
        Debug.Log(rigidbody2D.name);

 
Debug.Log(" I am in scene - " + whichScene);
Debug.Log ("It should stop the water after " + removeGravityNumber + " fails");
    }

   

    void FixedUpdate(){

        rigidbody2D.gravityScale = Globals.gravityScale;

    }

 

 

    private void OnTriggerEnter2D(Collider2D collision)

    {

       

        if (collision.CompareTag("Player"))

        {

            Globals.numFail++;
            Debug.Log(Globals.numFail);

           

            if (Globals.numFail<removeGravityNumber){

            SceneManager.LoadScene(scene.name);

            }

            else{

 

             Globals.gravityScale = 0.001f;

             SceneManager.LoadScene(scene.name);

            }

       

       }

    }

}

