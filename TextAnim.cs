using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextAnim : MonoBehaviour
{
    public TextMeshProUGUI textInProject;
    private string textInCode;

    private void Awake()
    {
        textInCode = textInProject.text;
        textInProject.text = "";
        StartCoroutine(TextCoroutine());
    }
    // Start is called before the first frame update
    void Start()
    {
        textInCode = textInProject.text;
        textInProject.text = "";
        StartCoroutine(TextCoroutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator TextCoroutine()
    {
        foreach (char abc in textInCode)
        {
            textInProject.text += abc;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
