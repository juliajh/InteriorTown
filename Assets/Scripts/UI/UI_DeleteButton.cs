using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_DeleteButton : MonoBehaviour
{
    public static UI_DeleteButton Instance;

    public Vector3 offset;
    public GameObject[] obj;

    private void Awake()
    {
        Instance = this;

        Hide();
    }



    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }

    public void AllDeleteButton()
    {
        FurnitureManager.Instance.CurrentInterObject?.DeleteObject();
        obj = GameObject.FindGameObjectsWithTag("Furniture");

        for (int i = 0; i < obj.Length; i++) 
        {
            DestroyObject(obj[i]);
        
        }
    }
    public void DeleteButton() 
    {
        FurnitureManager.Instance.CurrentInterObject?.DeleteObject();
    }



    public void LateUpdate()
    {
        if (FurnitureManager.Instance.CurrentInterObject == null)
        {
            Hide();
            return;
        }

        Vector3 newPosition = FurnitureManager.Instance.CurrentInterObject.transform.position + offset;
        newPosition.z = 0;

        this.transform.position = newPosition;
    }
}