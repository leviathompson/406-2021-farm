using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{


    private Text myText;
    private int currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<Text>();
        myText.text = "Time: " + currentTime.ToString();

        StartCoroutine(CountTime());
    }



    private IEnumerator CountTime()
    {
        while (true)
        {

            yield return new WaitForSeconds(1);
            currentTime += 1;
            myText.text = "Time: " + currentTime.ToString();

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
