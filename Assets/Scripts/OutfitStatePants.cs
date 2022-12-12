using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitStatePants : OutfitState
{
    public OutfitStatePants(OutfitManager manager) : base(manager){}

    public override void OnMyStateEntered()
    {
        string stateEnteredMessage = "Entered Pants State";
        Debug.Log(stateEnteredMessage);
        outfitManager.HideCanvas("select"); 
        outfitManager.ShowCanvas("pants");
    }
}
