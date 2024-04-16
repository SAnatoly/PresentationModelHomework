using UnityEngine;


    

    [CreateAssetMenu(fileName = "Hero", menuName = "Create hero")]
    public class Hero: ScriptableObject
    {
        [SerializeField]
        public string Name;
        [SerializeField, TextArea]
        public string Descripton;
        [SerializeField]
        public Sprite icon;
        [SerializeField]
        public CharacterStat[] stats;

        public int level;
        public int xp;
        public int needXp;
    }


