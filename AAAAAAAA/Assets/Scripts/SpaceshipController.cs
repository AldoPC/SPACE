using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{

	public int Life = 10;
	 public GameObject Missil;
    public GameObject Cannon1;
    public GameObject Cannon2;
    public Color EnemyColor;
    // Start is called before the first frame update
    void Start()
    {

    	InvokeRepeating("Shoot", 0.0f, 1.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector3(0,-.01f,0));
        Dead();
    }

    private void OnCollisionEnter2D(Collision2D other){

    	Debug.Log(other.gameObject);
    	
    	if (other.gameObject.CompareTag("Missil")){
    		Life--;
    		Destroy(other.gameObject);
    		StartCoroutine("SwitchColor");
    	} else{
    		Destroy(gameObject);
    	}
    }

    private void Dead(){

    	if(Life==0){

    		Destroy(gameObject);
    	}
    }

    void Shoot(){

    	Instantiate(Missil, Cannon1.transform.position, Quaternion.identity);
   		Instantiate(Missil, Cannon2.transform.position, Quaternion.identity);
   
    }

    IEnumerator SwitchColor()
    {

        GetComponent<SpriteRenderer>().color = Color.red;
         yield return new WaitForSeconds(0.5f);
        GetComponent<SpriteRenderer>().color = EnemyColor;
         yield return new WaitForSeconds(0.5f);

    }

}
