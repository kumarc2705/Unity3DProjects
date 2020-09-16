using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<=-10){
            Respawn();
        }
    }
    
    void Respawn(){
        float randomX = UnityEngine.Random.Range(-10,10);
        float randomY = UnityEngine.Random.Range(10,15);
        transform.position = new Vector3(randomX,randomY);
        var rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = Vector3.zero;
    }
    
    private void OnEnable(){
        Respawn();
    }
}
