using System.Collections;
using System.Collections.Generic;
using Models;
using Models.Clothes;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    private readonly ClothePiece[] clothes = ClothesFactory.GetClothes();
    private int clothePieceId;
    private bool fuckedUp;
    
    // Start is called before the first frame update
    void Start()
    {
        clothePieceId = 0;
        SetImage();
    }

    private void SetImage()
    {
        var imagePath = clothes[clothePieceId].ImagePath;
        GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
    }

    public void NextImage()
    {
        if (clothePieceId == clothes.Length - 1)
            clothePieceId = 0;
        else
            clothePieceId++;
        SetImage();
    }
}
