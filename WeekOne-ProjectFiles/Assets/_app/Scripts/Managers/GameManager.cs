using TMPro;
using UnityEngine;

namespace _app.Scripts.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        public TMP_Text scoreText;
        public int playerScore;

        private void Awake()
        {
            if(Instance != null)
            {
                Destroy(this);
            }
            else
            {
                Instance = this;
            }

            void ChangeScore(int scoreAmount)
            {
                playerScore = scoreAmount;
                scoreText.text = "Player Score: " + playerScore;
            }

        }
    }
}