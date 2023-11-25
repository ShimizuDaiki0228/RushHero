using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    int hp = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
	if(collision.gameObject.tag == "Player")
	{
		if(hp >= 2)
		{
	         	hp--;
			Debug.Log(hp);
		}

		else
		{
			GameObject.FindWithTag("GameController").SendMessage("Count");

			Destroy(this.gameObject);
		}
		
	}
    } 
}
