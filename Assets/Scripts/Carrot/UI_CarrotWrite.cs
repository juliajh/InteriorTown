using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using check;
using System;

public class UI_CarrotWrite : MonoBehaviour
{
    private CarrotResponseData m_Data;

    public Image m_image;
    public InputField m_FurnitureNameText;
    public InputField m_PriceText;
    public InputField m_TitleText;
    public InputField m_ContextText;
    public Dropdown m_CategoryText;
    public static UI_CarrotWrite Instance;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        Clear();
        gameObject.SetActive(false);
    }

    //Edit시 필요
    public void Init(CarrotResponseData data)
    {
        m_Data = data;
        Set();
    }

    private void Set()
    {
        if (m_Data == null)
        {
            return;
        }

        //m_Image.sprite = m_Data.imageSprite;
        m_CategoryText.value = Int32.Parse(m_Data.category);
        m_FurnitureNameText.text = m_Data.furnitureName;
        m_TitleText.text = m_Data.title;
        m_ContextText.text = m_Data.context;

        Debug.Log(m_ContextText.text);

        m_PriceText.text = m_Data.price;

    }

    public void SaveCarrot()
    {
        CarrotResponseData data = new CarrotResponseData()
        {
            category = m_CategoryText.value.ToString(),//m_CategoryText.options[m_CategoryText.value].text,
            furnitureName = m_FurnitureNameText.text.ToString(),
            price = m_PriceText.text.ToString(),
            title = m_TitleText.text.ToString(),
            context = m_ContextText.text.ToString(),
        };
        ImageUploader
                .Initialize()
                .SetTexture(m_image.sprite.texture)
                .SetFieldName("file")
                .SetFileName("file")
                .SetType(ImageType.JPG)
                .SetCategory(data.category) // 카테고리
                .SetFurnitureName(data.furnitureName) // 가구명 (상품명이므로 아무거나)
                .SetPrice(data.price) // 가격
                .SetTitle(data.title) // 게시글 제목
                .SetContext(data.context) // 게시글 내용
                .SetUploaderId() // DeviceId (자동으로 불러옴)
                .OnError(error => Debug.Log(error))
                .OnComplete(text => Debug.Log(text))
                .Upload();

        CarrotManager.Instance.CarrotList.Add(data);
        Close();
        UI_Carrot.Instance.Open();
    }

    private void Clear()
    {
        m_FurnitureNameText.text = "";
        m_PriceText.text = "";
        m_TitleText.text = "";
        m_ContextText.text = "";
        m_CategoryText.value = 0;
    }
}
