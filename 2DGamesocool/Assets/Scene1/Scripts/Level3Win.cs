using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level3Win : MonoBehaviour
{
    public TMP_Text One;
    public TMP_Text Two;
    public TMP_Text Three;
    public TMP_Text Four;
    public TMP_Text Five;
    public TMP_Text Six;
    public float TextTimer;
    public GameObject Trophy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Cutscene());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Cutscene()
    {
        yield return new WaitForSeconds(TextTimer);
        One.enabled = true;
        yield return new WaitForSeconds(TextTimer);
        One.enabled = false;
        Two.enabled = true;
        yield return new WaitForSeconds(TextTimer);
        Two.enabled = false;

        yield return new WaitForSeconds(TextTimer);
        Three.enabled = true;
        yield return new WaitForSeconds(TextTimer);
        Three.enabled = false;

        yield return new WaitForSeconds(TextTimer);
        Four.enabled = true;
        yield return new WaitForSeconds(TextTimer);
        Four.enabled = false;

        yield return new WaitForSeconds(TextTimer);
        Five.enabled = true;
        yield return new WaitForSeconds(TextTimer);
        Five.enabled = false;

        yield return new WaitForSeconds(TextTimer);
        Six.enabled = true;
        yield return new WaitForSeconds(TextTimer);
        Six.enabled = false;

        // Enable the Trophy
        Trophy.GetComponent<SpriteRenderer>().enabled = true;
        Trophy.GetComponent<BoxCollider2D>().enabled = true;
    }
}
