using TMPro;
using UnityEngine;
using UnityEngine.UI;


    public class LevelView: MonoBehaviour
    {
        [SerializeField]
        private TMP_Text levelText;
        [SerializeField]
        private TMP_Text experinceText;

        [SerializeField]
        private Image progress;
        
        

        public void Render(ILevelPresenterTemp levelPresenter)
        {
            
            levelPresenter.onDataChanged += () => Refresh(levelPresenter);
        }

        public void Refresh(ILevelPresenterTemp levelPresenter)
        {
            levelText.text = levelPresenter.LevelText;
            experinceText.text = levelPresenter.ProgressText;
            progress.fillAmount = levelPresenter.Progress;
            Debug.Log("JJJ");
            
        }
    }
