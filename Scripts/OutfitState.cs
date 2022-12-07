using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitState : MonoBehaviour
{
    
    public enum EventType
    {
        OutfitStart,
        OutfitSelect,
        OutfitHat,
        OutfitShirt,
        OutfitPants,
        OutfitShoes,
        OutfitEnd
    }

    protected OutfitManager outfitManager;
    public OutfitState(OutfitManager manager)
    {
        outfitManager = manager;
    }
    public virtual void OnMyStateEntered(){}
    public virtual void OnMyStateExit(){}
    public virtual void StateUpdate(){}

    //this method is not virtual because all states need a way to move to a new state
    //and would all have the same code
    public void OnEventRecieved(EventType eventType)
    {
        switch (eventType)
        {
            case (EventType.OutfitStart):
                outfitManager.NewOutfitState(outfitManager.outfitStateStart);
                break;
            case (EventType.OutfitSelect):
                outfitManager.NewOutfitState(outfitManager.outfitStateSelect);
                break;
            case (EventType.OutfitHat):
                outfitManager.NewOutfitState(outfitManager.outfitStateHat);
                break;
            case (EventType.OutfitShirt):
                outfitManager.NewOutfitState(outfitManager.outfitStateShirt);
                break;
            case (EventType.OutfitPants):
                outfitManager.NewOutfitState(outfitManager.outfitStatePants);
                break;
            case (EventType.OutfitShoes):
                outfitManager.NewOutfitState(outfitManager.outfitStateShoes);
                break;
            case (EventType.OutfitEnd):
                outfitManager.NewOutfitState(outfitManager.outfitStateEnd);
                break;
        }
    }
}
