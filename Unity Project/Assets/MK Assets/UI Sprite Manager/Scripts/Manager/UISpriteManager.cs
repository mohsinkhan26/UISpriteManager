/* 
 * Author : Mohsin Khan
 * LinkedIn : http://pk.linkedin.com/in/mohsinkhan26/
 * Github : https://github.com/mohsinkhan26/
 * BitBucket : https://bitbucket.org/unbounded-eagle/ 
*/
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using MK.Common.Utilities;
using MK.UISprite.API;

namespace MK.UISprite.Manager
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
    }
}
