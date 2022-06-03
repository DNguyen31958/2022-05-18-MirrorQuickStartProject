using UnityEngine;
using UnityEngine.SceneManagement;

namespace QuickStart
{
    public class GamesList : MonoBehaviour
    {
        public void LoadMenu()
        {
            SceneManager.LoadScene("0 Menu");
        }

        public void LoadMyScene()
        {
            SceneManager.LoadScene("2 MyScene");
        }

        public void LoadMyOtherScene()
        {
            SceneManager.LoadScene("3 MyOtherScene");
        }
    }
}