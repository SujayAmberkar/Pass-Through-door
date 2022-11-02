using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{

    public float moveSpeed = 3f;
    float direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed*Time.deltaTime*direction,0,0);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="Wall"){
            direction = -direction; 
        }
    }

    
}
