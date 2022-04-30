using System;
using System.Linq;
using Models;
using Models.Clothes;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        fuckedUp = false;
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
        {
            if (fuckedUp)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            else
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            TakeIntoAccountRoundResult();
            clothePieceId++;
            SetImage();
        }
    }

    private void TakeIntoAccountRoundResult()
    {
        var laundryProgram = BuildLaundryProgram();
        var result = clothes[clothePieceId].ProgramIsCorrect(laundryProgram);
        if (!result)
            fuckedUp = true;
    }

    private LaundryProgram BuildLaundryProgram()
    {
        var color = Enum.Parse<ColorType>(GetToggleValue("ColorToggle"));
        return new LaundryProgram() {Color = color};
    }

    private string GetToggleValue(string toggleGroupName)
    {
        var toggleGroup = GameObject.Find(toggleGroupName).GetComponent<ToggleGroup>();
        var toggleName = toggleGroup.ActiveToggles().Single().name;
        return toggleName.Replace("Toggle", "");
    }
}
