using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundscroller : MonoBehaviour {

	
        void OnTriggerExit2D(Collider2D col)
        {
            if (col.gameObject.tag == "Player")
            {
                transform.position +=  Vector3.right * GetComponent<SpriteRenderer>().bounds.size.x;
                //Multiply the old statement by 2
            }
        }
    }
	    
