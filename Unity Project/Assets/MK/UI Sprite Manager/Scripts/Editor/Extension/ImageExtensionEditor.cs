using UnityEngine.UI;
using UnityEngine;
using MK.Manager;
using MK.Utilities;
using System;

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
                if (SpriteManager.Instance.HasSprite(enumValue))
                    m_Sprite.objectReferenceValue = SpriteManager.Instance.GetSprite(enumValue);
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
