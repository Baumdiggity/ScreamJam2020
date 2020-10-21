using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Indicator : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI prompt;
    [SerializeField]
    GameObject flag;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void SetText(string txt)
    {
        prompt.text = txt;
    }

    public void SetFlag(bool b)
    {
        flag.SetActive(b);
    }
}
