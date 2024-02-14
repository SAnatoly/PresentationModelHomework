using UnityEditor;
using UnityEngine;

namespace LessonHelper
{
    [CustomEditor(typeof(LessonHelper))]
    public class LessonHelperEditor: Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            
            var lessonHelper = (LessonHelper)target;

            if (GUILayout.Button("Add money"))
            {
                lessonHelper.AddMoney();
            }
            
            if (GUILayout.Button("Spend money"))
            {
                lessonHelper.SpendMoney();
            }
            
            if (GUILayout.Button("Add gem"))
            {
                lessonHelper.AddGem();
            }
            
            if (GUILayout.Button("Spend gem"))
            {
                lessonHelper.SpendGem();
            }
        }
    }
}