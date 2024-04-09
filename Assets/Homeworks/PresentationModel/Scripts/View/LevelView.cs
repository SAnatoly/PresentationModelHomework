using TMPro;
using UnityEngine;
using UnityEngine.UI;


    public class LevelView: MonoBehaviour
    {
        [SerializeField]
        private TMP_Text levelText;

        [SerializeField]
        private Image progress;
        
        private ILevelPresenterTemp levelPresenterTemp;

        public void Render(ILevelPresenterTemp levelPresenter)
        {
            levelPresenterTemp = levelPresenter;
            
            levelPresenter.dataChanged += Refresh;
        }

        public void Refresh()
        {
            levelText.text = levelPresenterTemp.LevelText;
            progress.fillAmount = levelPresenterTemp.Progress;
        }
    }
