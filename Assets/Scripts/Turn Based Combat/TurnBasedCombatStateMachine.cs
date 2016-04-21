using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour {


    public enum BattleStates{
        START,
        INTERRUPT,
        PROGRESS,
        LOSE,
        WIN,
        RETREAT
    }
    
    private BattleStates currentState;
	// Use this for initialization
	void Start () {
	    currentState = BattleStates.START;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(currentState);
	    switch(currentState){
        case(BattleStates.START):
            break;
        case(BattleStates.INTERRUPT):
            break;
        case(BattleStates.PROGRESS):
            break;
        case(BattleStates.LOSE):
            break;
        case(BattleStates.WIN):
            break;
        case(BattleStates.RETREAT):
            break;
        }
	}
    
    void OnGUI(){
        if(GUILayout.Button("NEXT STATE")){
            if(currentState == BattleStates.START){
                currentState = BattleStates.INTERRUPT;
            }
        }
    }
}
