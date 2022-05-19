using UnityEngine;
using UnityEngine.SceneManagement;

namespace QuickStart
{
    public class GamesList : MonoBehaviour
    {
        public void LoadMenu()
        {
            SceneManager.LoadScene("Menu");
        }

        public void LoadMyScene()
        {
            SceneManager.LoadScene("MyScene");
        }

        public void LoadMyOtherScene()
        {
            SceneManager.LoadScene("MyOtherScene");
        }
    }
}