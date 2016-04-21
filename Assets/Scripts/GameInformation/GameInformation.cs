using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {


    void Awake(){
        DontDestroyOnLoad(transform.gameObject);    
    }
    
    public static string UnitName{get;set;}
    public static int UnitLevel{get;set;}
    public static BaseCharacterClass UnitClass{get;set;}
    public static int Health{get;set;}
    public static int Strength{get;set;}
    public static int Vitality{get;set;}
    public static int Intelligence{get;set;}
    public static int Resistance{get;set;}
    public static int Agility{get;set;}
    public static int Speed{get;set;}
    public static int Leadership{get;set;}
    public static int Morality{get;set;}
    public static int Luck{get;set;}
    public static int Experience{get;set;}

	public Texture2D cursorTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;
	void OnMouseEnter(){
		Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
	}
	void OnMouseExit(){
		Cursor.SetCursor(null, Vector2.zero, cursorMode);
	}
}
