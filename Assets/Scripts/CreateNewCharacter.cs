using UnityEngine;
using System.Collections;

public class CreateNewCharacter : MonoBehaviour {


    private BaseUnit newUnit;
    private bool isApprenticeMageClass;
    private bool isCadetClass;
    
	// Use this for initialization
	void Start () {
	    newUnit = new BaseUnit();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    
    void OnGUI(){
        isApprenticeMageClass = GUILayout.Toggle(isApprenticeMageClass, "Apprentice Mage Class");
        isCadetClass = GUILayout.Toggle(isCadetClass, "Cadet Class");
        if(GUILayout.Button("Create")){
            if(isApprenticeMageClass){
                newUnit.UnitClass = new BaseApprenticeMageClass();
            }else if(isCadetClass){
                newUnit.UnitClass = new BaseCadetClass();
            }
            newUnit.UnitLevel = 1;
            newUnit.Strength = newUnit.UnitClass.Strength;
            newUnit.Vitality = newUnit.UnitClass.Vitality;
            newUnit.Intelligence = newUnit.UnitClass.Intelligence;
            newUnit.Resistance = newUnit.UnitClass.Resistance;
            newUnit.Agility = newUnit.UnitClass.Agility;
            newUnit.Speed = newUnit.UnitClass.Speed;
            newUnit.Leadership = newUnit.UnitClass.Leadership;
            newUnit.Morality = newUnit.UnitClass.Morality;
            newUnit.Luck = newUnit.UnitClass.Luck;
            newUnit.Experience = 0;
            Debug.Log("Unit Class: " + newUnit.UnitClass.CharacterClassName);
            Debug.Log("Unit Level: " + newUnit.UnitLevel);
            Debug.Log("Strength: " + newUnit.Strength);
            Debug.Log("Intelligence: " + newUnit.Intelligence);
        }
    }
}
