using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    //public static UIController Instance { get; private set; }

    //void Awake()
    //{
    //    if (Instance != null)
    //    {
    //        Destroy(gameObject);
    //        return;
    //    }
    //    Instance = this;
    //}

    public List<UITarget> Targets;
}
