using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zzz : MonoBehaviour
{
    public Text myText;

    int test = 0;

    void Update()
    {
        myText.text = test.ToString();

        test++;
    }
}
