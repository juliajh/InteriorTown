using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedObject :InteriorObject
{
    public Bed m_Bed;
 


    public void Make(Bed bed)
    {
        FurnitureType = FurnitureType.Bed;

        m_Bed = bed;

        Index = m_Bed.Data.Index;

        m_SpriteRenderer.sprite = m_Bed.Data.FrontImage;
    }

    public override void SetIndex(int index)
    {
        Make(BedManager.Instance.List[index]);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isSelected == true)
        {
            RotationObject();
        }
    }
    public override void LoadTurnObject(Direction dir)
    {
        print("//////////"+dir);
        switch (dir)
        {
            case Direction.Front:
                {
                    //transform.Rotate(0, 0, 90);
                    //direction = Direction.Right;
                    m_SpriteRenderer.sprite = m_Bed.Data.FrontImage;
                    //StartCoroutine(Spin());
                    //Rortate();
                }
                break;
            case Direction.Right:
                {
                    //transform.Rotate(0, 0, 90);
                    //direction = Direction.Left;
                    m_SpriteRenderer.sprite = m_Bed.Data.RightImage;
                }
                break;
            case Direction.Left:
                {
                    //transform.Rotate(0, 0, 90);
                    direction = Direction.Front;
                    m_SpriteRenderer.sprite = m_Bed.Data.LeftImage;
                    //Rortate();
                }
                break;
        }
    }
    public override void RotationObject() 
    {
        switch (direction)
        {
            case Direction.Front:
                {
                    //transform.Rotate(0, 0, 90);
                    direction = Direction.Right;
                    m_SpriteRenderer.sprite = m_Bed.Data.RightImage;
                    //StartCoroutine(Spin());
                    //Rortate();
                }
                break;
            case Direction.Right:
                {
                    //transform.Rotate(0, 0, 90);
                    direction = Direction.Left;
                    m_SpriteRenderer.sprite = m_Bed.Data.LeftImage;
                }
                break;
            case Direction.Left:
                {
                    //transform.Rotate(0, 0, 90);
                    direction = Direction.Front;
                    m_SpriteRenderer.sprite = m_Bed.Data.FrontImage;
                    //Rortate();
                }
                break;
        }
    }

}
