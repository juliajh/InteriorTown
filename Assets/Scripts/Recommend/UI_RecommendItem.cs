using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using DG.Tweening;

public class UI_RecommendItem : MonoBehaviour
{
    private RecommendResponseData m_Data;

    public RawImage m_IconImage;
    public TextMeshProUGUI m_NameText;
    public TextMeshProUGUI m_PriceText;
    public TextMeshProUGUI m_DescriptionText;

    public void Init(RecommendResponseData data)
    {
        m_Data = data;
        
        Set();
    }

    private void Set()
    {
        m_NameText.text = m_Data.Title;
        m_PriceText.text = $"{Int32.Parse(m_Data.Price):N0}₩";
        m_DescriptionText.text = $"{m_Data.Category} / {m_Data.Color} / {m_Data.Brand}";

        StartCoroutine(DownloadImage(m_Data.Image));
    }

    IEnumerator DownloadImage(string MediaUrl)
    {
        string url = $"{NetDefine.NET_SERVER_ADDR}/proxy/{MediaUrl}";
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(url);

        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.LogError(request.error);
        }
        else
        {
            m_IconImage.texture = ((DownloadHandlerTexture) request.downloadHandler).texture;
        }
    } 
    
    public void OnClickBuyButton()
    {
        Application.OpenURL(m_Data.Link);
    }

    Vector3 destination = new Vector3(-5.66f, 3.46f);
    GameObject particleTransform;

    public void OnClickBasketButton() 
    {
        //장바구니 리스트에 추가 할 항목
        print(m_Data.Image);
        print(m_Data.Price);
        print(m_Data.Link);
        print(m_Data.Title);


        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        FurnitureManager.Instance.putButton.transform.position = worldPosition;
        particleTransform = Instantiate(FurnitureManager.Instance.putButton);
        
        //particleTransform.transform.DOMove(destination,2);
        


        BasketManager.Instance.AddBasket(m_Data);
        //basketImage.texture = ((DownloadHandler)request.downloadHandler)m_Data.Image;
    }
    



}
