using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialogueAdvance : MonoBehaviour
{
    DialogueUI _ui;
    // Start is called before the first frame update
    void Start()
    {
        _ui = FindObjectOfType<DialogueUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _ui.MarkLineComplete();
        }
    }
}
