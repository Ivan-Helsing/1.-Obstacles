using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameTriggers
{

    public class ButtonsTrigger : MonoBehaviour
    {
        [Header("Gameplay Triggers")]
        [SerializeField] GameObject groundPlatform;
        [SerializeField] GameObject firstPlatform;
        [SerializeField] GameObject threePlatforms;
        [SerializeField] GameObject cube;
        [SerializeField] GameObject longPlatform;
        [SerializeField] GameObject stairway;

        [Header("Game Over Triggers")]
        [SerializeField] GameObject explanationUI;
        [SerializeField] GameObject hintUI;
        [SerializeField] GameObject gameOverUI;

        [Header("Pause Menu Objects")]
        [SerializeField] GameObject pauseMenuUI;
        [SerializeField] GameObject playerFollowCamera;

        [Header("Obstacles Positions")]
        [SerializeField] Vector3 startPositionForCube;
        [SerializeField] Vector3 newPositionForCube;

        [Header("Triggers")]
        [SerializeField] GameObject groundButtonTrigger;
        [SerializeField] GameObject firstButtonTrigger;
        [SerializeField] GameObject secondButtonTrigger;
        [SerializeField] GameObject stairsZoneTrigger;


        void OnTriggerEnter(Collider collider)
        {
            if (collider.tag == "Button 3") { GroundCubeMovingToTunnel(); }

            if (collider.tag == "Button 1") { FirstButtonPressed(); }

            if (collider.tag == "Button 2") { SecondButtonPressed(); }

            if (collider.tag == "Zone") { ZoneActivated(); }

            if (collider.tag == "Game Over")
            {
                GameOver();
                Pause();
            }
        }

        void GameOver()
        {
            HideUI();
            gameOverUI.SetActive(true);
            pauseMenuUI.SetActive(false);
        }

        private void HideUI()
        {
            explanationUI.SetActive(false);
            hintUI.SetActive(false);
        }

        void CameraStopFollow()
        {
            if (!playerFollowCamera.activeSelf)
            {
                playerFollowCamera.SetActive(true);
                return;
            }
            playerFollowCamera.SetActive(false);
        }

        void PauseMenuUI()
        {
            if (pauseMenuUI.activeSelf)
            {
                pauseMenuUI.SetActive(false);
                return;
            }
            pauseMenuUI.SetActive(true);
        }

        void PauseMenu()
        {
            Pause();
            PauseMenuUI();
            CameraStopFollow();
        }

        void GroundCubeMovingToTunnel()
        {
            groundPlatform.transform.position = newPositionForCube;
            groundPlatform.transform.Rotate(90f, 0f, 0f);
            groundButtonTrigger.SetActive(false);
        }

        void FirstButtonPressed()
        {
            firstPlatform.SetActive(true);
            threePlatforms.SetActive(true);
            cube.SetActive(true);
            firstButtonTrigger.SetActive(false);
        }

        void SecondButtonPressed()
        {
            longPlatform.SetActive(true);
            secondButtonTrigger.SetActive(false);
        }

        void ZoneActivated()
        {
            stairway.SetActive(true);
            stairsZoneTrigger.SetActive(false);
        }

        public void Pause()
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        public void Resume()
        {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            PauseMenuUI();
            CameraStopFollow();
        }

        public void GameQuit()
        {
            Application.Quit();
        }

        public void OnPause(InputValue value) 
        {

            if (gameOverUI.activeSelf) { return; }
            if (Time.timeScale == 0)
            {
                Resume();
                return;
            }
            PauseMenu(); 
        }

        public void SupportOnPatreon()
        {
            Application.OpenURL("https://www.patreon.com/ivanhelsing");
        }

    }
}
