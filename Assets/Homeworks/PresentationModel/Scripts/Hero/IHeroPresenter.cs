using UnityEngine;

namespace Lessons.Architecture.PM
{
    public interface IHeroPresenter
    {
        string Name { get; }
        string description { get; }
        Sprite icon { get; }
        int level { get; }
        int xp { get; }
        int RequiredExperience { get; }
        CharacterStat[] characterStats { get; }
    }
}

