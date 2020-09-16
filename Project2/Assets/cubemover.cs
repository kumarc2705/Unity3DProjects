using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cubemover : MonoBehaviour
{
    // Update is called once per frame
    
    [SerializeField]
    private float speed = 1;

    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal,vertical);

        transform.position += movement * Time.deltaTime * speed; 
    }
   
    public void OnCollisionEnter(Collision collision){
        SceneManager.LoadScene(1);
    } 
}

