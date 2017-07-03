using UnityEngine;
using System.Collections.Generic;
using MK.Common.Utilities;
using MK.Utilities;
using System;
using System.Linq;

namespace MK.Manager
{
    public sealed class UISpriteManager : Singleton<UISpriteManager>
    {
        [SerializeField]
        List<SpriteData> sprite = new List<SpriteData>();

        /// <summary>
        /// Determines whether this instance has sprite of the specified _spriteEnum.
        /// </summary>
        /// <returns><c>true</c> if this instance has sprite the specified _spriteEnum; otherwise, <c>false</c>.</returns>
        /// <param name="_spriteEnum">Sprite enum.</param>
        public bool HasSprite(SpriteEnum _spriteEnum)
        {
            if (sprite.FirstOrDefault(item => item.spriteEnum == _spriteEnum).sprite != null)
                return true;
            return false;
        }

        /// <summary>
        /// Gets the sprite.
        /// </summary>
        /// <returns>The sprite.</returns>
        /// <param name="_spriteEnum">Sprite enum.</param>
        public Sprite GetSprite(SpriteEnum _spriteEnum)
        {
            if (!sprite.Exists(item => item.spriteEnum == _spriteEnum))
                return null;
            return sprite.FirstOrDefault(item => item.spriteEnum == _spriteEnum).sprite;
        }

        [Serializable]
        class SpriteData
        {
            /// <summary>
            /// Saves sprite enum respective to sprite
            /// </summary>
            public SpriteEnum spriteEnum;

            /// <summary>
            /// Saves sprite respective to enum
            /// </summary>
            public Sprite sprite;
        }
    }
}
