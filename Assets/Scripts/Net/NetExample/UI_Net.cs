using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class UI_Net : MonoBehaviour
{
    /*
    public void OnClickLoginButton()
    {
        Login();
    }
    public async UniTaskVoid Login()
    {
        var response = await NetManager.Post<ResponseLoginPacket>(new RequestLoginPacket());

        if (response.Result)
        {
            UnityEngine.Debug.Log(response.Result);
            UnityEngine.Debug.Log(response.Map);
        }
        
    }

    */
    public void OnClickSaveButton()
    {
       // Save();

        FurnitureManager.Instance.Save();
    }

    public async UniTaskVoid Save()
    {
        var response = await NetManager.Post<ResponseSavePacket>(new RequestSavePacket("{id: 134234}"));

        if (response.Result)
        {
            UnityEngine.Debug.Log("저장 성공");
        }
    }

    public void OnClickRecommendButton()
    {
       Recommend();
    }

    public  async UniTaskVoid Recommend()
    {
        // 가구 타입
        // 가구 아이디
        // 가구 색상

        RecommendRequestData recommendRequestData = new RecommendRequestData
        {
            FurnitureType = FurnitureType.Chair.ToString(),
            ColorType = ColorType.Blue.ToString()
        };
        
        var response = await NetManager.Post<ResponseRecommendPacket>(new RequestRecommendPacket(recommendRequestData));

        if (response.Result)
        {
            int count = response.Data.Length;

            var responseData = response.Data;
            
            for (int i = 0; i < count; ++i)
            {
                var data = responseData[i];
                Debug.Log(data.Category);
                Debug.Log(data.Color);
                Debug.Log(data.Title);
                Debug.Log(data.Link);
                Debug.Log(data.Image);
                Debug.Log(data.Brand);
                Debug.Log(data.Price);
            }
        }
    }


    public void OnClickRandomRecommendButton()
    {
        RandomRecommend();
    }

    public async UniTaskVoid RandomRecommend()
    {
        // 가구 타입
        // 가구 아이디
        // 가구 색상


        var response = await NetManager.Post<ResponseRecommendPacket>(new RequestRecommendRandomPacket());

        if (response.Result)
        {
            int count = response.Data.Length;

            var responseData = response.Data;

            for (int i = 0; i < count; ++i)
            {
                var data = responseData[i];
                Debug.Log(data.Category);
                Debug.Log(data.Color);
                Debug.Log(data.Title);
                Debug.Log(data.Link);
                Debug.Log(data.Image);
                Debug.Log(data.Brand);
                Debug.Log(data.Price);
            }
        }
    }


}
