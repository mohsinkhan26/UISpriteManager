/* 
 * Author : Mohsin Khan
 * LinkedIn : http://pk.linkedin.com/in/mohsinkhan26/
 * Github : https://github.com/mohsinkhan26/
 * BitBucket : https://bitbucket.org/mohsinkhan26/ 
*/
using UnityEngine;
using MK.Common.Utilities;
using MK.UISprite.API;

namespace MK.UISprite.Manager
{
    public sealed class UISpriteManager : Singleton<UISpriteManager>
    {
        [SerializeField]
        SpriteData spriteData;

        public bool HasSprite(SpriteEnum _spriteEnum)
        {
            return spriteData.HasSprite(_spriteEnum);
        }

        public Sprite GetSprite(SpriteEnum _spriteEnum)
        {
            return spriteData.GetSprite(_spriteEnum);
        }
    }
}
