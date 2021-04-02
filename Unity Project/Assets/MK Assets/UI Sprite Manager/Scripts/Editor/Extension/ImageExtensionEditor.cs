/* 
 * Author : Mohsin Khan
 * Portfolio : http://mohsinkhan26.github.io/ 
 * LinkedIn : http://pk.linkedin.com/in/mohsinkhan26/
 * Github : https://github.com/mohsinkhan26/
*/
using System;
using UnityEngine;
using UnityEngine.UI;
using MK.UISprite.Manager;
using MK.UISprite.API;

namespace UnityEditor.UI
{
    [CustomEditor(typeof(ImageExtension), true)]
    [CanEditMultipleObjects]
    public class ImageExtensionEditor : ImageEditor
    {
        SerializedProperty m_AutoSetOnEnable;
        SerializedProperty m_SpriteEnum;

        SerializedProperty m_Sprite;

        protected override void OnEnable()
        {
            base.OnEnable();

            m_AutoSetOnEnable = serializedObject.FindProperty("m_autoSetOnEnable");
            m_SpriteEnum = serializedObject.FindProperty("m_spriteEnum");

            m_Sprite = serializedObject.FindProperty("m_Sprite");
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EditorGUILayout.Space();

            serializedObject.Update();
            EditorGUILayout.PropertyField(m_AutoSetOnEnable);
            EditorGUILayout.PropertyField(m_SpriteEnum);

            if (GUILayout.Button("Set Image Now"))
            {
                SpriteEnum enumValue = (SpriteEnum)Enum.Parse(typeof(SpriteEnum), ((int)(m_SpriteEnum.enumValueIndex)).ToString());
                if (UISpriteManager.Instance.HasSprite(enumValue))
                    m_Sprite.objectReferenceValue = UISpriteManager.Instance.GetSprite(enumValue);
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
