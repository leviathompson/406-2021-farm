using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantOnMouse : MonoBehaviour
{

    public GameObject plant;
    public GameObject particles;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector2 spawnLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(plant, spawnLocation, transform.rotation);
            Instantiate(particles, spawnLocation, transform.rotation);
        }
    }
}
