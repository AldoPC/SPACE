using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{

	public GameObject objectToSpawn;
    public GameObject objectToSpawn2;


    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("Respawn2", 0.0f, 4.0f);

    }

    // Update is called once per frame
    void Update()
    {


    }

    void Respawn(){

    	Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), gameObject.transform.position.y , Random.Range(-10.0f, 10.0f));
    	Instantiate(objectToSpawn, position, Quaternion.identity);

    }

    void Respawn2(){

        Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), gameObject.transform.position.y , Random.Range(-10.0f, 10.0f));
        Instantiate(objectToSpawn2, position, Quaternion.identity);

    }
}
