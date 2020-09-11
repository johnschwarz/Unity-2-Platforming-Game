using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public int score;
    public int health = 100;
    public List<Collectable> inventory = new List<Collectable>();

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
