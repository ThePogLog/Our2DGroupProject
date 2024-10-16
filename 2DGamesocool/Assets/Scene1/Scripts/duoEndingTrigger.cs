using System.Collections;
using System.Collections.Generic;
using UnityEditor.Presets;
using UnityEngine;

public class duoEndingTrigger : MonoBehaviour
{
    [SerializeField]
    bool jumpscareTime = false;
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

        if (collision.gameObject.tag == "platformingDuoCharacter")
        {
            jumpscareTime = true;
        }
    }
}
