using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HoleCollision : MonoBehaviour
{

    public GameManager gameManager;
    public List<GameObject> valueableBox;
    public int countsValuableBox;
    

    void Start()
    {
        valueableBox = new List<GameObject>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {

      if (other.gameObject.tag == "true box"){

          countsValuableBox += 1;
          
          valueableBox.Add(other.gameObject);
          
      }

      if (countsValuableBox == 3){

          gameManager.GetComponent<GameManager>().LevelComplete();

      }
    }

    
}
