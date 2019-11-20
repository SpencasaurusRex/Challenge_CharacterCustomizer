using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ListSelect : MonoBehaviour
{

    public List<GameObject> Items;
    public Transform CharacterBaseTransform;
    public TextMeshProUGUI Text;

    int selection;

    GameObject instantiated;
    bool fired;

    void Awake()
    {
        Choose();
    }

    void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == gameObject)
        {
            var horizontal = Input.GetAxis("Horizontal");
            if (horizontal > 0.3f)
            {
                if (!fired)
                {
                    Right();
                    fired = true;
                }
            }
            else if (horizontal < -0.3f)
            {
                if (!fired)
                {
                    Left();
                    fired = true;
                }
            }
            else
            {
                fired = false;
            }
        }
    }

    public void Left()
    {
        selection--;
        if (selection < 0) selection = Items.Count - 1;
        Choose();
    }

    public void Right()
    {
        selection = (selection + 1) % Items.Count;
        Choose();
    }

    void Choose()
    {
        if (instantiated != null)
        {
            Destroy(instantiated);
        }

        GameObject toInstantiate = Items[selection];
        instantiated = Instantiate(toInstantiate);
        instantiated.transform.SetParent(CharacterBaseTransform, false);
        instantiated.transform.localPosition = Vector3.zero;

        Text.text = Items[selection].name;
    }
}
