using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ResultText : MonoBehaviour
{

    
    public HoleCollision holeCollision;
    TextMeshProUGUI resultText;
    string value;

    void Start()
    {
        resultText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (holeCollision.countsValuableBox == 3){

            resultText.text =  holeCollision.valueableBox[1].GetComponentInChildren<TextMeshPro>().text + "+" + holeCollision.valueableBox[2].GetComponentInChildren<TextMeshPro>().text + "=" + holeCollision.valueableBox[0].GetComponentInChildren<TextMeshPro>().text;
        }
    }
}
