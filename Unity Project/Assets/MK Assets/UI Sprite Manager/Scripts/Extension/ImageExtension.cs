/* 
 * Author : Mohsin Khan
 * Portfolio : http://mohsinkhan26.github.io/ 
 * LinkedIn : http://pk.linkedin.com/in/mohsinkhan26/
 * Github : https://github.com/mohsinkhan26/
*/
using System;
using MK.UISprite.API;
using MK.UISprite.Manager;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Extensions/Image Extension"), RequireComponent(typeof(RectTransform))]
    public class ImageExtension : Image
    {
        [Header("Extended Properties")]
        [Tooltip("Do sprite would be set OnEnable, bi-default true")]
        [SerializeField]
        bool m_autoSetOnEnable = true;
        [Tooltip("Respective SpriteEnum for this component")]
        [SerializeField]
        SpriteEnum m_spriteEnum;

        public bool AutoSetOnEnable
        {
            get
            {
                return m_autoSetOnEnable;
            }
            set
            {
                m_autoSetOnEnable = value;
            }
        }

        public SpriteEnum SpriteEnum
        {
            get
            {
                return m_spriteEnum;
            }
            set
            {
                m_spriteEnum = value;
            }
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            //Debug.Log("ImageExtension-OnEnable: " + name);
            if (m_autoSetOnEnable && UISpriteManager.Instance.HasSprite(m_spriteEnum))
                this.sprite = UISpriteManager.Instance.GetSprite(m_spriteEnum);
            else
                Debug.LogError("ImageExtension-OnGameObject: " + name + "   Has no sprite related to Enum: " + m_spriteEnum.ToString());
        }

        /// <summary>
        /// Sets the sprite enum and sprite
        /// </summary>
        /// <param name="_spriteEnum">Sprite enum.</param>
        public void SetSpriteEnum(SpriteEnum _spriteEnum)
        {
            m_spriteEnum = _spriteEnum;
            if (UISpriteManager.Instance.HasSprite(m_spriteEnum))
                this.sprite = UISpriteManager.Instance.GetSprite(m_spriteEnum);
            else
                Debug.LogError("ImageExtension-OnGameObject: " + name + "   Has no sprite related to Enum: " + _spriteEnum.ToString());
        }

        /// <summary>
        /// Sets the sprite enum, sprite and perform action OnSuccess
        /// </summary>
        /// <param name="_spriteEnum">Sprite enum.</param>
        /// <param name="_onSuccess">On success.</param>
        public void SetSpriteAndPerform(SpriteEnum _spriteEnum, Action _onSuccess)
        {
            m_spriteEnum = _spriteEnum;
            if (UISpriteManager.Instance.HasSprite(m_spriteEnum))
            {
                this.sprite = UISpriteManager.Instance.GetSprite(m_spriteEnum);
                if (_onSuccess != null)
                    _onSuccess();
            }
            else
                Debug.LogError("ImageExtension-OnGameObject: " + name + "   Has no sprite related to Enum: " + _spriteEnum.ToString());
        }
    }
}
