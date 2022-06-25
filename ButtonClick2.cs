using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick2 : MonoBehaviour
{

    public Text textToEdit;
    public Text HeadText;
    public RawImage ImageToEdit;
    public Texture[] textures = new Texture[6];
    string t1 = "Адрес 1",t2 = "Адрес 2", t3= "Адрес 3", t4 = "Адрес 4", t5 = "Адрес 5", t6 = "Адрес 6";
    string h1 = "Название 1", h2 = "Название 2", h3 = "Название 3", h4 = "Название 4", h5 = "Название 5", h6 = "Название 6";
    void Start()
    {
        switch (DataHolder.levelStart)
        {

            case 0:
                HeadText.text = h1;
                textToEdit.text = t1;
                ImageToEdit.texture = textures[0];
                break;
            case 1:
                HeadText.text = h2;
                textToEdit.text = t2;
                ImageToEdit.texture = textures[1];
                break;
            case 2:
                HeadText.text = h3;
                textToEdit.text = t3;
                ImageToEdit.texture = textures[2];
                break;
            case 3:
                HeadText.text = h4;
                textToEdit.text = t4;
                ImageToEdit.texture = textures[3];
                break;
            case 4:
                HeadText.text = h5;
                textToEdit.text = t5;
                ImageToEdit.texture = textures[4];
                break;
            case 5:
                HeadText.text = h6;
                textToEdit.text = t6;
                ImageToEdit.texture = textures[5];
                break;
        }
    }
    void Update()
    {

    }
}
