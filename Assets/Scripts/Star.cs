using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public GameObject victoryPanel;
    public GameObject[] circles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "MainCircle")
        {
            circles = GameObject.FindGameObjectsWithTag("PatrolCircle");
            foreach (GameObject circle in circles)
            {
                Destroy(circle);
            }
            victoryPanel.SetActive(true);
        }
    }
}
