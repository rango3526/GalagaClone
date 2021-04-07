using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    GameObject gc;

    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            gameObject.SendMessage("Die");
            Destroy(gameObject);
        }
        else if (coll.gameObject.tag == "Finish")
        {
            gameObject.SendMessage("Finish");
            Destroy(gameObject);
        }
            
    }

    void Die()
    {
        if (gc != null)
        {
            //gc.SendMessage("EnemyDied");
        }
    }

    void Finish()
    {
        if (gc != null)
        {
            //gc.SendMessage("EnemyReachedEnd");
        }
    }
}
