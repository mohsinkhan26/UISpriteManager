using UnityEngine;
using UnityEditor;
using UnityEditorInternal;
using MK.Manager;
using System.Xml;

namespace MK.Manager
{
    [CustomEditor(typeof(SpriteManager))]
    public class SpriteManagerEditor : Editor
    {
        private ReorderableList list;
        const float COLUMN_MARGIN = 10f;

        private void OnEnable()
        {
            list = new ReorderableList(serializedObject, serializedObject.FindProperty("sprite"), true, true, true, true);
            list.elementHeight = 80f;

            list.drawHeaderCallback = (Rect rect) =>
            {  
                EditorGUI.LabelField(rect, "Sprite Data");
            };

            list.drawElementCallback = 
                (Rect rect, int index, bool isActive, bool isFocused) =>
            { // called to draw the elements

                var element = list.serializedProperty.GetArrayElementAtIndex(index);
                rect.y += 2;
                float rowWidth = rect.width / 1.5f;

                EditorGUI.PropertyField(
                    new Rect(rect.x, rect.y, rowWidth, EditorGUIUtility.singleLineHeight),
                    element.FindPropertyRelative("spriteEnum"), GUIContent.none);
                EditorGUI.PropertyField(
                    new Rect(rect.x, rect.y + EditorGUIUtility.singleLineHeight + COLUMN_MARGIN, rowWidth, EditorGUIUtility.singleLineHeight),
                    element.FindPropertyRelative("sprite"), GUIContent.none);
                if (element.FindPropertyRelative("sprite").objectReferenceValue != null)
                {
                    Sprite _sprite = (element.FindPropertyRelative("sprite").objectReferenceValue as Sprite);
                    if (_sprite != null)
                    {
                        EditorGUI.LabelField(
                            new Rect(rect.x, rect.y + ((EditorGUIUtility.singleLineHeight + COLUMN_MARGIN) * 2), rowWidth, EditorGUIUtility.singleLineHeight * 2),
                            "Belongs to following texture");
                            
                        GUIStyle style = new GUIStyle();
                        style.normal.background = _sprite.texture;
                        EditorGUI.LabelField(new Rect(rect.x + rowWidth + (rowWidth / 14f), rect.y, 70f, 70f), GUIContent.none, style);
                    }
                }
            };
            
            list.onSelectCallback = (ReorderableList l) =>
            { // called when an entry is selected
                var sprite = l.serializedProperty.GetArrayElementAtIndex(l.index).FindPropertyRelative("sprite").objectReferenceValue as Sprite;
                if (sprite)
                    EditorGUIUtility.PingObject(sprite);
            };
            
            list.onCanRemoveCallback = (ReorderableList l) =>
            {  
                return l.count > 1;
            };
            
            list.onRemoveCallback = (ReorderableList l) =>
            {
                if (EditorUtility.DisplayDialog("Warning!", 
                        "Are you sure you want to delete the sprite? It might have references.", "Yes", "No"))
                {
                    ReorderableList.defaultBehaviours.DoRemoveButton(l);
                }
            };
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            list.DoLayoutList();
            serializedObject.ApplyModifiedProperties();
        }
    }
}
