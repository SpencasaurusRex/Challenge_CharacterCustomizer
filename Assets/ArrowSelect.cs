using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowSelect : MonoBehaviour
{

    public Selectable sel;
    public ListSelect ls;
    public Button button;

    public bool Right;

    void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
    }

    void Update()
    {
        
    }

    void Click()
    {
        sel.Select();
        if (Right)
        {
            ls.Right();
        }
        else
        {
            ls.Left();
        }
    }
}
