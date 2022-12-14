using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    Front,
    Right,
    Back,
    Left,

    Count,
}

public abstract class InteriorObject : MonoBehaviour
{
    private Bed m_Bed;

    public FurnitureType FurnitureType;
    public int Index;

    public SpriteRenderer triggerRenderer;

    public bool isSelected = false;
    public bool canArrangeMent = true;

    public Material m_Material;
    public SpriteRenderer m_SpriteRenderer;
    public BoxCollider2D furnitureCollider;
    public Rigidbody2D furnitureRigidBody;

    float distance;


    public Direction direction = Direction.Front;

    public abstract void SetIndex(int index);

    private void Awake()
    {
        furnitureRigidBody = GetComponent<Rigidbody2D>();
        furnitureCollider = GetComponent<BoxCollider2D>();
        m_Material = GetComponent<SpriteRenderer>().material;
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }


    public void ColorChange() 
    {
        Color color = m_SpriteRenderer.color;

        color.a = 0.5f;
        m_SpriteRenderer.color = color;
        print("color chabnge");
    }

    private void OnMouseDown()
    {
        if (gameObject.tag != "RecommendFurniture")
        {
            Debug.Log("Down");
            isSelected = true;
            m_Material.EnableKeyword("OUTBASE_ON");
            gameObject.tag = "Furniture";

            FurnitureManager.Instance.SetCurrentInterObject(this);
            //UI_RotateButton.Instance.Show();


            
        }
        
    }
    Vector3 position;

    private void OnMouseDrag()
    {
        if (!isSelected) return;

        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (FurnitureType==FurnitureType.PhotoFrame ) 
        {
            worldPosition.x = Mathf.Clamp(worldPosition.x, (float)-4.45, (float)4.49);
            worldPosition.y = Mathf.Clamp(worldPosition.y, (float)3.8, (float)4.16);
        }
        else 
        {
            worldPosition.x = Mathf.Clamp(worldPosition.x, (float)-4.43, (float)4.43);
            worldPosition.y = Mathf.Clamp(worldPosition.y, (float)-0.87, (float)3.17);
        }

        /*worldPosition.x = Mathf.Clamp(worldPosition.x, (float)-4.39, (float)4.61);
        worldPosition.y = Mathf.Clamp(worldPosition.y, (float)-1.3, (float)3);
*/      worldPosition.z = 0;


        transform.position = worldPosition;


        if (FurnitureManager.Instance.recommendFurniture.Count >= 1)
        {
            distance = Vector2.Distance(gameObject.transform.position, FurnitureManager.Instance.recommendFurniture[0].transform.position);
            if (distance < 0.2f)
            {
                FurnitureManager.Instance.destroyParticle.transform.position = FurnitureManager.Instance.recommendFurniture[0].transform.position;
                Instantiate(FurnitureManager.Instance.destroyParticle);
                Destroy(FurnitureManager.Instance.recommendFurniture[0].gameObject);
                FurnitureManager.Instance.recommendFurniture.RemoveAt(0);
               

            }
        }
        else 
        {
            return;
        }

    }



    private void OnMouseUp()
    {
        isSelected = false;

        m_Material.DisableKeyword("OUTBASE_ON");
        if (gameObject.tag != "RecommendFurniture") 
        {
            /*FurnitureManager.Instance.putObject.transform.position= FurnitureManager.Instance.gameObject.transform.position;
            Instantiate(FurnitureManager.Instance.putObject);*/
            if (FurnitureManager.Instance.recommendFurniture.Count >= 1)
            {
                Destroy(FurnitureManager.Instance.recommendFurniture[0].gameObject);
                FurnitureManager.Instance.recommendFurniture.RemoveAt(0);
                FurnitureManager.Instance.Save();
            }
            else
            {
                return;
            }

        }

        //FurnitureManager.Instance.SetCurrentInterObject(null);
    }


    public virtual void RotationObject()
    {
        print("Rotate");
        direction = (Direction)((int)direction + 1);
        transform.Rotate(0, 0, 90);
        

    }

    public virtual void LoadRoatate(Direction ImageDir)
    {
        print("Rotate");
        direction = (Direction)((int)direction + 1);
        //direction = ImageDir;
        //transform.Rotate(0, 0, 90);


    }

    public virtual void LoadTurnObject(Direction dir)
    {
        //print("Rotate");
        //direction = (Direction)((int)direction + 1);

        switch (dir) 
        {
            case Direction.Front:
                {
                    transform.Rotate(0, 0, 0);
                }
                break;
            case Direction.Back:
                {
                    transform.Rotate(0, 0, 180);
                }
                break;
            case Direction.Left:
                {
                    transform.Rotate(0, 0, 270);
                }
                break;
            case Direction.Right:
                {
                    transform.Rotate(0, 0, 90);
                }
                break;
        }
    }


    /*public void ChangeDirection(Direction dir)
    {
        switch (dir)
        {
            case Direction.Front:
                {
                    //transform.Rotate(0, 0, 90);
                    direction = Direction.Right;
                    m_SpriteRenderer.sprite = .Data.LeftImage;
                    //StartCoroutine(Spin());
                    //Rortate();
                }
                break;
            case Direction.Right:
                {
                    //transform.Rotate(0, 0, 90);
                    direction = Direction.Left;
                    m_SpriteRenderer.sprite = be.Data.LeftImage;
                }
                break;
            case Direction.Left:
                {
                    //transform.Rotate(0, 0, 90);
                    direction = Direction.Front;
                    m_SpriteRenderer.sprite = be.Data.FrontImage;
                    //Rortate();
                }
                break;
        }
    }*/

    /* public virtual void DeleteObject() 
     {
         Destroy(gameObject);
     }*/


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LeftWall"))
        {
            NuckBack(Vector2.right*30f);   
        }

        if (collision.gameObject.CompareTag("RightWall"))
        {
            NuckBack(Vector2.left*30f);
        }

        /*if (collision.gameObject.CompareTag("Furniture")&&isSelected == true) 
        {

            NuckBack(Vector2.right*30f);
        }*/
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RightWall") || collision.gameObject.CompareTag("LeftWall"))
        {
            StartCoroutine(StopRigidBody());
        }
        if (collision.gameObject.CompareTag("Furniture")) 
        {
            print(gameObject.name);
            StartCoroutine(StopRigidBody());
        }
    }
    
    IEnumerator StopRigidBody()
    {
        yield return new WaitForSeconds(0.1f);
        print("Start");
        furnitureCollider.isTrigger = true;
        furnitureRigidBody.bodyType = RigidbodyType2D.Kinematic;
        furnitureRigidBody.velocity = new Vector2(0, 0);

    }


    void NuckBack(Vector2 dir) 
    {
        print("NuckBack");
        //print(col);
        /*furnitureCollider = gameObject.GetComponent<BoxCollider2D>();
        furnitureRigidBody = gameObject.GetComponent<Rigidbody2D>();*/
        //furnitureCollider.isTrigger = false;

        furnitureRigidBody.gravityScale = 0f;
        furnitureRigidBody.bodyType = RigidbodyType2D.Dynamic;
        furnitureRigidBody.AddForce(dir);
        //furnitureRigidBody.velocity = new Vector2(1.4f, 0);
    }


}
