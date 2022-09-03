using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set;}
    private int count = 0;
    public int Count { get { return count; } }
    public float speed = 1;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void AddToCount()
    {
        count++;
    }
    public void SetSpeed(float value)
    {
        speed = value;
    }
    
    
}
