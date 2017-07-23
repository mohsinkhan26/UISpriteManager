/* 
 * Author : Mohsin Khan
 * LinkedIn : http://pk.linkedin.com/in/mohsinkhan26/
 * Github : https://github.com/mohsinkhan26/
 * BitBucket : https://bitbucket.org/unbounded-eagle/ 
*/
using System;
using UnityEngine;

namespace MK.UISprite.API
{
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
