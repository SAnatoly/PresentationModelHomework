using TMPro;
using UnityEngine;

namespace Lessons.Architecture.PM
{
    public class LevelView: MonoBehaviour
    {
        public TMP_Text levelText;

        public void Show(LevelPresenter presenter)
        {
            levelText.text = presenter.level.ToString();
        }
        
        public void LevelUp(LevelPresenter presenter)
        {
            presenter.LevelUP();
        }
    }
}