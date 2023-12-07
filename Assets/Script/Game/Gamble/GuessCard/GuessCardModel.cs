using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuessCardModel : BaseModel<GuessCardModel>
{
    private int _card = -1;
    private int _guessCard = -1;
    private int _maxGuessCnt = 3;
    private int _guessCnt = 0;

    private void InitCard()
    {
        _card = -1;
        _guessCard = -1;
    }
    
    public void GameStart()
    {
        InitCard();
        _card = Random.Range(0, 52);

        while (_guessCnt < _maxGuessCnt)
        {
            this.EventCall("OnPlayerMove");
        }
    }

    public void Guess(int card)
    {
        _guessCard = card;
        if (_guessCard == _card)
        {
            GameEnd(true);
        }
        if (++_guessCard > _guessCnt)
        {
            GameEnd(false);
        }
    }

    public void GameEnd(bool win)
    {
        this.EventCall("OnGameEnd",win);
    }
}
