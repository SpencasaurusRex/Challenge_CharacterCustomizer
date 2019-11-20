using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectedButton : MonoBehaviour
{

    void Awake()
    {
        GetComponent<Button>().onClick.AddListener(Click);
    }

    void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == gameObject)
        {
            if (Input.GetAxisRaw("Accept") > 0 || Input.GetKeyDown(KeyCode.Return))
            {
                Click();
            }
        }
    }

    public void Click()
    {
        print("Click");
    }
}
