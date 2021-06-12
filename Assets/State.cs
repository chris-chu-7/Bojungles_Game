using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{

    //serializing field makes things available inside of the script
   [TextArea(14, 10)] [SerializeField] string storyText;
   [SerializeField] State[] nextStates;

   public string GetStateStory() {
       return storyText;
   }


   public State[] GetNextStates() {
       return nextStates; 
   }





}
