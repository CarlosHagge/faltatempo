using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public double timeLeft = 15;
    public Text timeText;
    public GameObject restartPanel;
    public GameObject[] circles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( timeLeft > 0 )
        {
            timeLeft -= Time.deltaTime;
        }        
        if ( timeLeft <= 0 )
        {
            restartPanel.SetActive(true);
            circles = GameObject.FindGameObjectsWithTag("MainCircle");
            foreach (GameObject circle in circles)
            {
                Destroy(circle);
            }
        }
        timeText.text = string.Concat("Tempo restante: ", System.String.Format("{0:0}s", timeLeft));
    }
}
