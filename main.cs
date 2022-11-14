using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class openCode : MonoBehaviour
{
    public GameObject sigh;
    public GameObject nearT1;
    public GameObject textShow;
    void start
    {

    }
    void update
    {
 if (Input.GetKey(KeyCode.E) && atS == true)
        {
            sigh.SetActive(true);
            nearT1.SetActive(false);
            textShow.SetActive(true);

        }
if (Input.GetKey(KeyCode.Escape) && sigh == true || textShow == true)
{
    sigh.SetActive(false);
    textShow.SetActive(false);
}
if (Input.GetKey(KeyCode.Q) && sigh == true)
{
    textShow.SetActive(true);
}
    }
 private void OnTriggerEnter(Collider other)
{
    if (other.tag == "Player")
    {
        atS = true;
        nearT1.SetActive(true);
    }

}
private void OnTriggerExit(Collider other)
{
    atS = false;
    sigh.SetActive(false);
    nearT1.SetActive(false);
    textShow.SetActive(false);



}
}
