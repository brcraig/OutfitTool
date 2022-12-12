using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour
{
    public SoundManager sounds;
    public OutfitManager outfitManager;

    public Button ShirtDisplay;
    public Button BottomDisplay;
    public Button ShoesDisply;
    public Button HatsDisplay;

    public Button ZoomedShirt;
    public Button ZoomedBottoms;
    public Button ZoomedShoes;
    public Button ZoomedHats;

    public Sprite resetBlank;

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
        sounds.PlayClickSound();
        Application.Quit();
    }

    public void ActionStartGame()
    {
        //Debug.Log("about to play game");
        sounds.PlayClickSound();
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitStart);
    }

    public void ActionSelection()
    {
        //Debug.Log("about to select something");
        sounds.PlayClickSound();
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitSelect);
    }

    public void ActionSelectHat()
    {
        //Debug.Log("about to select a hat");
        sounds.PlayClickSound();
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitHat);
    }

    public void ActionSelectShirt()
    {
        //Debug.Log("about to select a shirt");
        sounds.PlayClickSound();
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitShirt);
    }

    public void ActionSelectPants()
    {
        //Debug.Log("about to select a pair of pants");
        sounds.PlayClickSound();
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitPants);
    }

    public void ActionSelectShoes()
    {
        //Debug.Log("about to select a pair of shoes");
        sounds.PlayClickSound();
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitShoes);
    }

    public void ActionEndGame()
    {
        //Debug.Log("about to end game");
        sounds.PlayClickSound();
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitEnd);
        
        ShirtDisplay.GetComponent<Image>().sprite = resetBlank;
        ShirtDisplay.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedShirt.GetComponent<Image>().sprite = resetBlank;
        ZoomedShirt.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        
        BottomDisplay.GetComponent<Image>().sprite = resetBlank;
        BottomDisplay.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedBottoms.GetComponent<Image>().sprite = resetBlank;
        ZoomedBottoms.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        
        ShoesDisply.GetComponent<Image>().sprite = resetBlank;
        ShoesDisply.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedShoes.GetComponent<Image>().sprite = resetBlank;
        ZoomedShoes.GetComponent<Image>().color = new Color(255, 255, 255, 255);

        HatsDisplay.GetComponent<Image>().sprite = resetBlank;
        HatsDisplay.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedHats.GetComponent<Image>().sprite = resetBlank;
        ZoomedHats.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        
    }

    public void OnShirtClick(Sprite Item)
    {
        //Debug.Log("clicked on a clothing item");
        sounds.PlayClickSound();
        ShirtDisplay.GetComponent<Image>().sprite = Item;
        ShirtDisplay.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedShirt.GetComponent<Image>().sprite = Item;
        ZoomedShirt.GetComponent<Image>().color = new Color(255, 255, 255, 255);
    }
    public void OnBottomsClick(Sprite Item)
    {
        //Debug.Log("clicked on a clothing item");
        sounds.PlayClickSound();
        BottomDisplay.GetComponent<Image>().sprite = Item;
        BottomDisplay.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedBottoms.GetComponent<Image>().sprite = Item;
        ZoomedBottoms.GetComponent<Image>().color = new Color(255, 255, 255, 255);
    }
    public void OnShoesClick(Sprite Item)
    {
        //Debug.Log("clicked on a clothing item");
        sounds.PlayClickSound();
        ShoesDisply.GetComponent<Image>().sprite = Item;
        ShoesDisply.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedShoes.GetComponent<Image>().sprite = Item;
        ZoomedShoes.GetComponent<Image>().color = new Color(255, 255, 255, 255);
    }
    public void OnHatsClick(Sprite Item)
    {
        //Debug.Log("clicked on a clothing item");
        sounds.PlayClickSound();
        HatsDisplay.GetComponent<Image>().sprite = Item;
        HatsDisplay.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedHats.GetComponent<Image>().sprite = Item;
        ZoomedHats.GetComponent<Image>().color = new Color(255, 255, 255, 255);
    }
}

