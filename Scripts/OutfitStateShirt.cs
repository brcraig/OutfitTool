using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitStateShirt : OutfitState
{
    public OutfitStateShirt(OutfitManager manager) : base(manager){}

    public override void OnMyStateEntered()
    {
        string stateEnteredMessage = "Entered Shirt State";
        Debug.Log(stateEnteredMessage);
        outfitManager.HideCanvas("select"); 
        outfitManager.ShowCanvas("shirt");
    }
}
