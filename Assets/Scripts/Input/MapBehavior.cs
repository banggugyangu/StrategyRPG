using UnityEngine;
using System.Collections;

public class MapBehavior : MonoBehaviour {
	public UnitInformation unitInformation;


	// Use this for initialization
	void Start () {
		unitInformation = new UnitInformation();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseClick(){
		if(GUILayout.Button ("Unit Information")){

			GUILayout.Label ("" + unitInformation.UnitName);
			GUILayout.Label ("" + unitInformation.UnitClass);
			GUILayout.Label ("Level:  " + unitInformation.UnitLevel);
			GUILayout.Label ("Health:  " + unitInformation.Health);
			GUILayout.Label ("Strength:  " + unitInformation.Strength);
			GUILayout.Label ("Vitality:  " + unitInformation.Vitality);
			GUILayout.Label ("Agility:  " + unitInformation.Agility);
			GUILayout.Label ("Intelligence:  " + unitInformation.Intelligence);
			GUILayout.Label ("Resistance:  " + unitInformation.Resistance);
			if(unitInformation.Speed != 0){
				GUILayout.Label ("Spell Speed:  " + unitInformation.Speed);
			}
			GUILayout.Label ("Leadership:  " + unitInformation.Leadership);
			GUILayout.Label ("Morality:  " + unitInformation.Morality);
			GUILayout.Label ("Luck:  " + unitInformation.Luck);
			GUILayout.Label ("Experience:  " + unitInformation.Experience);
		}
	}

}
