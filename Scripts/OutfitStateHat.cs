using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitStateHat : OutfitState
{
    public OutfitStateHat(OutfitManager manager) : base(manager){}

    public override void OnMyStateEntered()
    {
        string stateEnteredMessage = "Entered Hat State";
        Debug.Log(stateEnteredMessage);
        outfitManager.HideCanvas("select"); 
        outfitManager.ShowCanvas("hat");
        
    }
}

