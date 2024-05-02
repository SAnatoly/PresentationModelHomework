using UnityEngine;


    public interface IHeroPresenter
    {
        string Name { get; }
        string Description { get; }
        Sprite Icon { get; }
        int Level { get; }
        int Xp { get; }
        int RequiredExperience { get; }
        CharacterStat[] CharacterStats { get; }
    }


