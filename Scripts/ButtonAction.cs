using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour
{
    public OutfitManager outfitManager;

    public Button ShirtDisplay;
    public Button ZoomedShirt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseApplication()
    {
        Application.Quit();
    }
    public void ActionStartGame()
    {
        Debug.Log("about to play game");
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitStart);
    }
    public void ActionSelection()
    {
        Debug.Log("about to select something");
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitSelect);
    }
    public void ActionSelectHat()
    {
        Debug.Log("about to select a hat");
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitHat);
    }
    public void ActionSelectShirt()
    {
        Debug.Log("about to select a shirt");
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitShirt);
    }
    public void ActionSelectPants()
    {
        Debug.Log("about to select a pair of pants");
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitPants);
    }
    public void ActionSelectShoes()
    {
        Debug.Log("about to select a pair of shoes");
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitShoes);
    }
    public void ActionEndGame()
    {
        Debug.Log("about to end game");
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitEnd);
    }

    public void OnShirtClick(Sprite Item)
    {
        Debug.Log("clicked on a clothing item");
        ShirtDisplay.GetComponent<Image>().sprite = Item;
        ShirtDisplay.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedShirt.GetComponent<Image>().sprite = Item;
    }
}
