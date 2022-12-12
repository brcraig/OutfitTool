using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitStateSelect : OutfitState
{
    public OutfitStateSelect(OutfitManager manager) : base(manager){}

    public override void OnMyStateEntered()
    {
        string stateEnteredMessage = "Entered Selection State";
        Debug.Log(stateEnteredMessage);
        outfitManager.HideCanvas("start");
        outfitManager.HideCanvas("hat");
        outfitManager.HideCanvas("shirt");
        outfitManager.HideCanvas("pants");
        outfitManager.HideCanvas("shoes");
        outfitManager.ShowCanvas("select");
        
    }
}