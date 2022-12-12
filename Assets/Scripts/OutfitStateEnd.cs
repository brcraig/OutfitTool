using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitStateEnd : OutfitState
{
    public OutfitStateEnd(OutfitManager manager) : base(manager){}

    public override void OnMyStateEntered()
    {
        string stateEnteredMessage = "Entered Ending State";
        Debug.Log(stateEnteredMessage);
        outfitManager.HideCanvas("select");
        outfitManager.ShowCanvas("end");
        
    }
}
