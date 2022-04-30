using System.Collections;
using System.Collections.Generic;
using Models;
using Models.Clothes;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    private ClothePiece[] clothes = ClothesFactory.GetClothes();
    private int clothePieceId;
    
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
}
