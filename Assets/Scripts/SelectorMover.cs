using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectorMover : MonoBehaviour
{
    public RectTransform Selector;
    public Vector2 Offset;
    EventSystem es;

    void Awake()
    {
        es = GetComponent<EventSystem>();
    }

    void Update()
    {
        if (es.currentSelectedGameObject != null)
            Selector.position = es.currentSelectedGameObject.transform.position - (Vector3)Offset;
    }
}
