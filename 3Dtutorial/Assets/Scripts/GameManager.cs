using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    enum CurrentPlayer
    {   
        Player1,
        Player2
    }

    CurrentPlayer currentPlayer;
    bool isWinningShotForPlayer1 = false;
    bool isWinningShotForPlayer2 = false;
    int player1BallsRemaining = 7;
    int player2BallsRemaining = 7;
    bool isWaitingForBallMovementToStop = false;
    bool willSwapPlayers = false;
    bool isGameOver = false;
    bool ballPocketed = false;

    [SerializeField] float shotTimer = 3f;
    private float currentTimer;

    [SerializeField] float movementThreshold;

    [SerializeField] TextMeshProUGUI player1BallsText;
    [SerializeField] TextMeshProUGUI player2BallsText;
    [SerializeField] TextMeshProUGUI currentTurnText;
    [SerializeField] TextMeshProUGUI messageText;

    [SerializeField] Camera cueStickCamera;
    [SerializeField] Camera overheadCamera;
    Camera currentCamera;

    [SerializeField] GameObject restartButton;

    [SerializeField] Transform headPosition;

    void ReturnCue(Collider cue)
    {
        cue.gameObject.transform.position = headPosition.position;
        cue.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        cue.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }

    void Start()
    {
        currentPlayer = CurrentPlayer.Player1;
        currentCamera = cueStickCamera;
        currentTimer = shotTimer;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentCamera == overheadCamera)
        {
            SwitchCameras();
        }
        if (isWaitingForBallMovementToStop && !isGameOver)
        {
            currentTimer -= Time.deltaTime;
            if(currentTimer > 0)
            {
                return;
            }
            bool allStopped = true;
            foreach(GameObject ball in GameObject.FindGameObjectsWithTag("Ball"))
            {
                if(ball.GetComponent<Rigidbody>().velocity.magnitude >= movementThreshold)
                {
                    allStopped = false;
                    break;
                }
            }
            if(allStopped || !ballPocketed)
            {
                isWaitingForBallMovementToStop = false;
                if(willSwapPlayers || !ballPocketed)
                {
                    NextPlayerTurn();
                }
                else
                {
                    SwitchCameras();
                }
                currentTimer = shotTimer;
                ballPocketed = false;
            }
        }
    }

    public void SwitchCameras()
    {
        if(currentCamera == cueStickCamera)
        {
            cueStickCamera.enabled = false;
            overheadCamera.enabled = true;
            currentCamera = overheadCamera;
            isWaitingForBallMovementToStop = true;
        }
        else
        {
            cueStickCamera.enabled = true;
            overheadCamera.enabled = false;
            currentCamera = cueStickCamera;
            currentCamera.gameObject.GetComponent<CameraController>().ResetCamera();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    bool Scratch()
    {
        if(currentPlayer == CurrentPlayer.Player1)
        {
            if(isWinningShotForPlayer1)
            {
                ScratchOnWinningShot("Player 1");
                return true;
            }
        }
        else
        {
            if(isWinningShotForPlayer2)
            {
                ScratchOnWinningShot("Player 2");
                return true;
            }
        }
        willSwapPlayers = true;
        return false;
    }

    void EarlyEightBall()
    {
        if(currentPlayer == CurrentPlayer.Player1)
        {
            Lose("Player 1 Hit in the Eight Ball Too Early and Has Lost. Player 2 Wins!");
        }
        else
        {
            Lose("Player 2 Hit in the Eight Ball Too Early and Has Lost. Player 1 Wins!");
        }
    }

    void ScratchOnWinningShot(string player)
    {
        Lose(player + " Scratched on their final shot and has lost");
    }
    /*
    void NoMoreBalls(CurrentPlayer player)
    {
        if(player == CurrentPlayer.Player1)
            isWinningShotForPlayer1 = true;
        else
            isWinningShotForPlayer2 = true;
    }*/

    bool CheckBall(Ball ball)
    {
        if(ball.IsCueBall())
        {
            if(Scratch())
                return true;
            else
            return false;
        }
        else if(ball.isEightBall())
        {
            if(currentPlayer == CurrentPlayer.Player1)
            {
                if(isWinningShotForPlayer1)
                {
                    Win("Player 1");
                    return true;
                }
            }
            else
            {
                if(isWinningShotForPlayer2)
                {
                    Win("Player 2");
                    return true;
                }
            }
            EarlyEightBall();
        }
        else
        {
            if(ball.IsBallRed())
            {
                player1BallsRemaining--;
                player1BallsText.text = "Player 1 Balls Remaining: " + player1BallsRemaining;
                if(player1BallsRemaining <= 0)
                {
                    isWinningShotForPlayer1 = true;
                }
                if(currentPlayer != CurrentPlayer.Player1)
                {
                    //NextPlayerTurn();
                    isWaitingForBallMovementToStop = true;
                }
                if(currentPlayer != CurrentPlayer.Player1)
                {
                    willSwapPlayers = true;
                }
            }
            else
            {
                player2BallsRemaining--;
                player2BallsText.text = "Player 2 Balls Remaining: " + player2BallsRemaining;
                if(player2BallsRemaining <= 0)
                {
                    isWinningShotForPlayer2 = true;
                }
                if(currentPlayer != CurrentPlayer.Player2)
                {
                    //NextPlayerTurn();
                    isWaitingForBallMovementToStop = true;
                }
                if(currentPlayer != CurrentPlayer.Player2)
                {
                    willSwapPlayers = true;
                }
            }
        }
        return true;
    }

    void Lose(string message)
    {
        messageText.gameObject.SetActive(true);
        messageText.text = message;
        restartButton.SetActive(true);
        isGameOver = true;
    }

    void Win(string player)
    {
        messageText.gameObject.SetActive(true);
        messageText.text = player + " has won";
        restartButton.SetActive(true);
        isGameOver = true;
    }

    void NextPlayerTurn()
    {
        if (currentPlayer == CurrentPlayer.Player1)
        {
            currentPlayer = CurrentPlayer.Player2;
            currentTurnText.text = "Current Turn: Player 2";
        }
        else
        {
            currentPlayer = CurrentPlayer.Player1;
            currentTurnText.text = "Current Turn: Player 1";
        }
        willSwapPlayers = false;
        SwitchCameras();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            ballPocketed = true;
            if(CheckBall(other.gameObject.GetComponent<Ball>()))
            {
                Destroy(other.gameObject);
            }
            else
            {
                ReturnCue(other);
            }
        }
    }

}
