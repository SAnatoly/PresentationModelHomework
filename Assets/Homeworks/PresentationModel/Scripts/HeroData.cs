using System;
using UnityEngine;


    [CreateAssetMenu(menuName = "Create hero data")]
    public class HeroData: ScriptableObject
    {
        public string name;
        public string description;
        public Sprite icon;
        
        public StatsHero[] stats;
    }

    [Serializable]
    public class StatsHero
    {
        public string nameStats;
        public string stats;
    }