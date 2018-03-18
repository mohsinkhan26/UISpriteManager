/* 
 * Author : Mohsin Khan
 * LinkedIn : http://pk.linkedin.com/in/mohsinkhan26/
 * Github : https://github.com/mohsinkhan26/
 * BitBucket : https://bitbucket.org/mohsinkhan26/ 
*/
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MK.UISprite.API
{
    [CreateAssetMenu(fileName = "SpriteData", menuName = "Game/Sprite Data", order = 1)]
    public class SpriteData : ScriptableObject
    {
        [SerializeField]
        List<SpriteDetail> sprites;

        /// <summary>
        /// Determines whether this instance has sprite of the specified _spriteEnum.
        /// </summary>
        /// <returns><c>true</c> if this instance has sprite the specified _spriteEnum; otherwise, <c>false</c>.</returns>
        /// <param name="_spriteEnum">Sprite enum.</param>
        public bool HasSprite(SpriteEnum _spriteEnum)
        {
            if (sprites.FirstOrDefault(item => item.spriteEnum == _spriteEnum).sprite != null)
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
            if (!sprites.Exists(item => item.spriteEnum == _spriteEnum))
                return null;
            return sprites.FirstOrDefault(item => item.spriteEnum == _spriteEnum).sprite;
        }
    }
}
