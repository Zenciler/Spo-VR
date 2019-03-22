using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arkakol1 : MonoBehaviour
{
    public Text myText;

    double count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        count += 1;
        if(count % 285 == 0)
        {
            myText.text = "Tekrar Sayisi : " + (count / 285);
        }

    }
}
