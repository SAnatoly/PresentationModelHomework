using UnityEngine;

namespace Lessons.Architecture.PM
{
    public class HeroPresenter : IHeroPresenter
    {
        public string Name => hero.Name;

        public string description => hero.Descripton;

        public Sprite icon => hero.icon;
        public int level => hero.level;
        public int xp => hero.xp;
        public int RequiredExperience { get; }
        public CharacterStat[] characterStats => hero.stats;

        private readonly Hero hero;

        public HeroPresenter(Hero _hero)
        {
            hero = _hero;
        }
    }
}

