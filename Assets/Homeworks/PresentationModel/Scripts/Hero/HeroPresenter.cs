using UnityEngine;


    public class HeroPresenter : IHeroPresenter
    {
        public string Name => Hero.Name;

        public string Description => Hero.Descripton;

        public Sprite Icon => Hero.icon;
        public int Level => Hero.level;
        public int Xp => Hero.xp;
        public int RequiredExperience { get; }
        public CharacterStat[] CharacterStats => Hero.stats;

        private readonly Hero Hero;

        public HeroPresenter(Hero hero)
        {
            Hero = hero;
        }
    }


