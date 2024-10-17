using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnAnim : MonoBehaviour
{
    [SerializeField] 
    public Image Bar1;
    public Image Bar2;
    public Image InnerBar1;
    public Image InnerBar2;
    public Image InnerBar3;
    public Image InnerBar4;
    public Image InnerBar5;
    public Image InnerBar6;
    public Image InnerBar7;
    public Image InnerBar8;
    public Image InnerBar9;
    public Image InnerBar10;
    public Image InnerBar11;

    void Start()
    {
        StartCoroutine(SpawnDelay());
    }

    void Update()
    {
    }

    IEnumerator SpawnDelay()
    {
        while (true)
        {
            Bar1.GetComponent<Image>().enabled = true;
            Bar2.GetComponent<Image>().enabled = false;
            InnerBar1.GetComponent<Image>().enabled = true;
            InnerBar2.GetComponent<Image>().enabled = true;
            InnerBar3.GetComponent<Image>().enabled = true;
            InnerBar4.GetComponent<Image>().enabled = true;
            InnerBar5.GetComponent<Image>().enabled = true;
            InnerBar6.GetComponent<Image>().enabled = false;
            InnerBar7.GetComponent<Image>().enabled = false;
            InnerBar8.GetComponent<Image>().enabled = false;
            InnerBar9.GetComponent<Image>().enabled = false;
            InnerBar10.GetComponent<Image>().enabled = false;
            InnerBar11.GetComponent<Image>().enabled = false;
            yield return new WaitForSeconds(0.3f);
            Bar1.GetComponent<Image>().enabled = false;
            Bar2.GetComponent<Image>().enabled = true;
            InnerBar1.GetComponent<Image>().enabled = false;
            InnerBar2.GetComponent<Image>().enabled = false;
            InnerBar3.GetComponent<Image>().enabled = false;
            InnerBar4.GetComponent<Image>().enabled = false;
            InnerBar5.GetComponent<Image>().enabled = false;
            InnerBar6.GetComponent<Image>().enabled = true;
            InnerBar7.GetComponent<Image>().enabled = true;
            InnerBar8.GetComponent<Image>().enabled = true;
            InnerBar9.GetComponent<Image>().enabled = true;
            InnerBar10.GetComponent<Image>().enabled = true;
            InnerBar11.GetComponent<Image>().enabled = true;
            yield return new WaitForSeconds(0.3f);
        }
    }
}





