using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Collectable
{
    private void Start()
    {
        collectableName = "Coin";
        description = "Gives 10 Points";
    }

    public override void Use()
    {
        player.GetComponent<playerManager>().ChangeScore(10);
        
        Destroy(this.gameObject);
    }

    
}
