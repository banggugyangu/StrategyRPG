using UnityEngine;
using System.Collections;

public class SaveInformation : MonoBehaviour {

	public static void SaveAllInformation(){
		PlayerPrefs.SetInt ("UNITLEVEL", GameInformation.UnitLevel);
		PlayerPrefs.SetString ("UNITNAME", GameInformation.UnitName);
		PlayerPrefs.SetInt ("HEALTH", GameInformation.Health);
		PlayerPrefs.SetInt ("STRENGTH", GameInformation.Strength);
		PlayerPrefs.SetInt ("VITALITY", GameInformation.Vitality);
		PlayerPrefs.SetInt ("INTELLIGENCE", GameInformation.Intelligence);
		PlayerPrefs.SetInt ("RESISTANCE", GameInformation.Resistance);
		PlayerPrefs.SetInt ("AGILITY", GameInformation.Agility);
		PlayerPrefs.SetInt ("SPEED", GameInformation.Speed);
		PlayerPrefs.SetInt ("LEADERSHIP", GameInformation.Leadership);
		PlayerPrefs.SetInt ("MORALITY", GameInformation.Morality);
		PlayerPrefs.SetInt ("LUCK", GameInformation.Luck);
		PlayerPrefs.SetInt ("EXPERIENCE", GameInformation.Experience);
    }
}
