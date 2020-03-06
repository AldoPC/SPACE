using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public string PlayerName;
	public int Life = 10;
	public float Damage = 1f;
	public Color PlayerColor;
	public Camera Camera;
    public GameObject Missil;
    public GameObject Cum;

    // Start is called before the first frame update
    void Start()
    {
     
    	

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
		gameObject.transform.Translate(new Vector3(x,y,0));

        if(Input.GetKeyDown(KeyCode.Space)){
            Shoot();
            
        }
        Dead();
		

    }


    private void Shoot(){

Instantiate(Missil, Cum.transform.position, Quaternion.identity);

    }

    private void OnCollisionEnter2D(Collision2D other){

        Life--;
    	Destroy(other.gameObject);
    	StartCoroutine("SwitchColor");
    }


    IEnumerator SwitchColor()
    {

        GetComponent<SpriteRenderer>().color = Color.red;
         yield return new WaitForSeconds(0.5f);
        GetComponent<SpriteRenderer>().color = PlayerColor;
         yield return new WaitForSeconds(0.5f);

    }
    private void Dead(){

        if(Life==0){
         Destroy(gameObject);
        }

    }



}
