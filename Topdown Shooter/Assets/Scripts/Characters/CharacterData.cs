using UnityEngine;

namespace Characters
{
    [CreateAssetMenu(fileName = "newCharacterData", menuName = "Data/Character Data/Base Data", order = 0)]
    public class CharacterData : ScriptableObject
    {
        public float movementSpeed = 5;
        public float health = 100;

    }
}