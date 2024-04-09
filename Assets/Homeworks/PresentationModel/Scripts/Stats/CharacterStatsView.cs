using TMPro;
using UnityEngine;

    public class CharacterStatsView: MonoBehaviour
    {
        public TMP_Text name;
        public int value;

        public void Show(StatsPresenter presenter)
        {
            name.text = presenter.name;
            value = presenter.value;
        }

        public void ChangeValue(StatsPresenter presenter)
        {
            presenter.ChangeValue();
        }
    }
