using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Collectable
{
    private void Start()
    {
        collectableName = "Coin";
        description = "Increase Score by 10";
    }
    public override void Use()
    {
        player.GetComponent<playerManager>().info.inventory.Remove(this);
        player.GetComponent<playerManager>().ChangeScore(10);
        Destroy(this.gameObject);
        
    }
}
