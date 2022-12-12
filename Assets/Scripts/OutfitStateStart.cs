using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitStateStart : OutfitState
{
    public OutfitStateStart(OutfitManager manager) : base(manager){}

    public override void OnMyStateEntered()
    {
        string stateEnteredMessage = "Entered Starting State";
        Debug.Log(stateEnteredMessage);
        outfitManager.HideCanvas("end"); 
        outfitManager.HideCanvas("select");
        outfitManager.ShowCanvas("start");
    }
}
