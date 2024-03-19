using UnityEngine;

namespace Lessons.Architecture.PM
{
    public interface IHeroPresenter
    {
        string Name { get; }
        string description { get; }
        Sprite icon { get; }
        CharacterStat[] characterStats { get; }
    }
}

