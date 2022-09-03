using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Belt : MonoBehaviour
{
    [SerializeField] Transform endpoint;
    [SerializeField] float speed;
    private void OnTriggerStay(Collider other) 
    {
        other.transform.position = Vector3.MoveTowards(other.transform.position, endpoint.position, GameManager.Instance.speed * Time.deltaTime);    
    }
    private void OnTriggerExit(Collider other) 
    {
        other.GetComponent<Rigidbody>().AddForce((endpoint.position - other.transform.position) * GameManager.Instance.speed * 20);
    }
}
