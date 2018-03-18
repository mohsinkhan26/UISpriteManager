/* 
 * Author : Mohsin Khan
 * LinkedIn : http://pk.linkedin.com/in/mohsinkhan26/
 * Github : https://github.com/mohsinkhan26/
 * BitBucket : https://bitbucket.org/mohsinkhan26/ 
*/
using UnityEngine;
using UnityEngine.UI;

namespace MK.UISprite
{
    public class Demo : MonoBehaviour
    {
        [SerializeField]
        Text message;
        [SerializeField]
        Text info;
        [SerializeField]
        GameObject[] spriteDemos;

        // Use this for initialization
        void Start()
        {
            message.text = "Press 0, 1, 2 or 3 to see UI Sprite Manager in action";
            info.text = "";
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha0))
                ShowRespectiveSprites(0);
            else if (Input.GetKeyDown(KeyCode.Alpha1))
                ShowRespectiveSprites(1);
            else if (Input.GetKeyDown(KeyCode.Alpha2))
                ShowRespectiveSprites(2);
            else if (Input.GetKeyDown(KeyCode.Alpha3))
                ShowRespectiveSprites(3);
        }

        void ShowRespectiveSprites(int _keyPressed)
        {
            switch (_keyPressed)
            {
                case 0: // 0 is pressed
                    spriteDemos[0].SetActive(false);
                    spriteDemos[1].SetActive(false);
                    spriteDemos[2].SetActive(false);
                    info.text = "0 is pressed: Disable all sprites";
                    break;
                case 1: // 1 is pressed
                    spriteDemos[0].SetActive(true);
                    spriteDemos[1].SetActive(false);
                    spriteDemos[2].SetActive(false);
                    info.text = "1 is pressed: indivdual sprites";
                    break;
                case 2: // 2 is pressed
                    spriteDemos[0].SetActive(false);
                    spriteDemos[1].SetActive(true);
                    spriteDemos[2].SetActive(false);
                    info.text = "2 is pressed: sprites from spritesheet";
                    break;
                case 3: // 3 is pressed
                    spriteDemos[0].SetActive(false);
                    spriteDemos[1].SetActive(false);
                    spriteDemos[2].SetActive(true);
                    info.text = "3 is pressed: individual and spritesheet mixture";
                    break;
            }
        }
    }
}
