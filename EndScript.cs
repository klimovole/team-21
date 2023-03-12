using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    public GameObject lastText;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        lastText.SetActive(true);
        Button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        lastText.SetActive(false);
        Button.SetActive(true);
    }
}
