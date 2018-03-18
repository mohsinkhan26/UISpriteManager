/* 
 * Author : Mohsin Khan
 * LinkedIn : http://pk.linkedin.com/in/mohsinkhan26/
 * Github : https://github.com/mohsinkhan26/
 * BitBucket : https://bitbucket.org/mohsinkhan26/ 
*/
using UnityEngine;
using UnityEditor;

namespace MK.UISprite.API
{
    public static class SpriteDataMenuEditor
    {
        private const string DATABASE_PATH = "Assets/MK Assets/UI Sprite Manager/SpriteData.asset";
        static SpriteData spriteData;

        [MenuItem("Tools/Game/Sprite Data", false, 8)]
        public static void ProjectConfiguration()
        {
            LoadSpriteData();
        }

        static void LoadSpriteData()
        {
            spriteData = (SpriteData)AssetDatabase.LoadAssetAtPath(DATABASE_PATH, typeof(SpriteData));
            Selection.activeObject = AssetDatabase.LoadMainAssetAtPath(DATABASE_PATH);

            if (spriteData == null)
                CreateSpriteData();

            // select the .asset fiile
            EditorGUIUtility.PingObject(spriteData);
            // focus the project window
            EditorUtility.FocusProjectWindow();
        }

        static void CreateSpriteData()
        {
            spriteData = ScriptableObject.CreateInstance<SpriteData>();
            AssetDatabase.CreateAsset(spriteData, DATABASE_PATH);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }
    }
}
