using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector3(0,-0.1f,0));
    }

    private void OnCollisionEnter2D(Collision2D other){
    	if (other.gameObject.CompareTag("Missil") || other.gameObject.CompareTag("Floor")) {

    		Destroy(gameObject);
    	}
    }
}