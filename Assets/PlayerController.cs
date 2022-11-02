using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public float speed = 5;
    public GameObject spawnPoint;
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        if(spawnPoint==null){
            spawnPoint = GameObject.FindWithTag("Respawn");
        }
        
        Player = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        Movements();
    }

    // player movements
    void Movements(){
        float x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        float y = Input.GetAxis("Vertical")*Time.deltaTime*speed;
        
        transform.Translate(x,y,0);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="Door"){
            
            transform.position = spawnPoint.transform.position;
        }
    }

}
