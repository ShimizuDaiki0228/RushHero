using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
	if(collision.gameObject.tag == "Player")
	{　
		collision.gameObject.SendMessage("Damage");

		Destroy(this.gameObject);	
	}

	if(collision.gameObject.tag == "Wall")
	{
		Destroy(this.gameObject);
	}
    }
}
