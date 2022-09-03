using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Counter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counterText;
    private void OnTriggerEnter(Collider other) 
    {
        GameManager.Instance.AddToCount();
        counterText.text = " Count:" + GameManager.Instance.Count;
    }
}
