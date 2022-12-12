using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitStateShoes : OutfitState
{
    public OutfitStateShoes(OutfitManager manager) : base(manager){}

    public override void OnMyStateEntered()
    {
        string stateEnteredMessage = "Entered Shoes State";
        Debug.Log(stateEnteredMessage);
        outfitManager.HideCanvas("select"); 
        outfitManager.ShowCanvas("shoes");
    }
}
