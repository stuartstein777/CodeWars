using System;

namespace CodeWars
{
    class Pong
{
    private int _maxScore;
    private int _currentPlayer = 1;     // toggle between 0 and 1 for player 1 and 2 respectively
    private int[] _scores = new[]{0,0};
    
    public Pong(int maxScore) => _maxScore = maxScore;

    public string play(int ballPos, int playerPos)
    {
        var opponent = _currentPlayer == 1 ? 2 : 1;
        var msg = string.Empty;
        if (_scores[0] >= _maxScore || _scores[1] >= _maxScore)
            msg = $"Game Over!";
        else if (ballPos <= (playerPos + 3) && ballPos >= (playerPos - 3))
        {
            msg = $"Player {_currentPlayer} has hit the ball!";
        }
        else
        {
            _scores[_currentPlayer == 1 ? 1 : 0]++;
            //$"Score: {_scores[0]} - {_scores[1]}".Dump();
            msg = _scores[_currentPlayer == 1 ? 1 : 0] == _maxScore
                    ? $"Player {opponent} has won the game!"
                    : $"Player {_currentPlayer} has missed the ball!";
        }
        _currentPlayer = _currentPlayer == 1 ? 2 : 1;
        return msg;
     }
   }
}