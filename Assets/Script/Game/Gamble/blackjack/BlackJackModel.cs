using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlackJackModel:BaseModel<BlackJackModel>
{
    private bool[] _allCards = new bool[52];
    private List<int> _playerCard = new List<int>();
    private List<int> _dealerCard = new List<int>();
    private bool _playerStand = false;
    private bool _dealerStand = false;
    private bool _gameEnd = false;
    private bool _insurance = false;
    
    public List<int> PlayerCards => _playerCard;
    public List<int> DealerCards => _dealerCard;

    public void GameStart()
    {
        InitGame();
        
        //玩家发牌
        Hit(true);
        Hit(true);
        //庄家发牌
        Hit(false);
        Hit(false);
        bool playerBlackJack = IsPlayerBlackJack();
        int dealerBlackJack = IsDealerBlackJack();
        this.EventCall("OnGameStart");
        //玩家BJ胜利
        if (playerBlackJack && (dealerBlackJack == 0 || dealerBlackJack == 2))
        {
            GameEnd(true);
        }
        //庄家BJ胜利
        if (!playerBlackJack && dealerBlackJack == 1)
        {
            GameEnd(false);
        }
        
        //保险
        if (dealerBlackJack == 2 || dealerBlackJack == 3)
        {
            this.EventCall("OnBuyInsurance",dealerBlackJack);
        }

        while (!IsEnd())
        {
            this.EventCall("OnPlayerMove");
        }
    }

    public bool IsEnd()
    {
        return _playerStand && _dealerStand;
    }

    public void BuyInsurance()
    {
        _insurance = true;
    }

    public bool HasInsurance()
    {
        return _insurance;
    }

    public void Stand(bool isPlayer)
    {
        if (isPlayer)
        {
            _playerStand = true;
        }
        else
        {
            _dealerStand = true;
        }

        CheckGameEnd();
    }

    private void CheckGameEnd()
    {
        if (_playerStand && _dealerStand)
        {
            GameEnd(GameResult());
        }
    }

    private void GameEnd(bool playerWin)
    {
        this.EventCall("OnGameEnd",playerWin);
    }
    
    public void InitGame()
    {
        for (int i = 0; i < _allCards.Length; i++)
        {
            _allCards[i] = false;
        }
        _playerStand = false;
        _dealerStand = false;
        _gameEnd = false;
        _insurance = false;
        _playerCard.Clear();
        _dealerCard.Clear();
    }

    /// <summary>
    /// 发牌
    /// </summary>
    /// <param name="isPlayer"></param>
    public void Hit(bool isPlayer)
    {
        int card = Deal();
        if (isPlayer)
        {
            _playerCard.Add(card);
        }
        else
        {
            _dealerCard.Add(card);
        }
        this.EventCall("UpdateView");
    }
    private int Deal()
    {
        int ret = Random.Range(0, 52);
        if (_allCards[ret] == false)
        {
            _allCards[ret] = true;
        }
        else
        {
            ret = Deal();
        }
        return ret;
    }

    /// <summary>
    /// 返回手牌点数
    /// </summary>
    /// <param name="isPlayer"></param>
    /// <returns></returns>
    public int CardPoint(bool isPlayer)
    {
        var judgeCards = isPlayer?_playerCard:_dealerCard;
        int ret = 0;
        int aceCnt = 0;
        for (int i = 0; i < judgeCards.Count; i++)
        {
            int point = Math.Clamp(judgeCards[i] / 4 + 1,1,10);
            aceCnt += point == 1?1:0;
            ret += judgeCards[i];
        }

        int aceRet = ret;
        for (int i = 0; i < aceCnt && aceCnt <= 21; i++)
        {
            ret = aceRet;
            aceRet += 10;
        }
        return ret;
    }

    /// <summary>
    /// 游戏结果，true玩家胜，false庄家胜
    /// </summary>
    /// <returns></returns>
    public bool GameResult()
    {
        return CardPoint(true) > CardPoint(false);
    }

    /// <summary>
    /// 判断玩家黑杰克是否成立
    /// </summary>
    /// <returns></returns>
    public bool IsPlayerBlackJack()
    {
        if (_playerCard.Count != 2)
        {
            return false;
        }
        bool gotA = false;
        bool gotT = false;
        for (int i = 0; i < 2; i++)
        {
            gotA |= _playerCard[i] < 4;
            gotT |= _playerCard[i] > 35;
        }
        return gotA && gotT;
    }

    /// <summary>
    /// 判断庄家黑杰克状态 0：无黑杰克 1：直接黑杰克 2:明牌A无黑杰克 3：明牌A有黑杰克
    /// </summary>
    /// <returns>0：无黑杰克 1：直接黑杰克 2:明牌A无黑杰克 3：明牌A有黑杰克</returns>
    public int IsDealerBlackJack()
    {
        if (_playerCard.Count != 2)
        {
            return 0;
        }
        if (_playerCard[0] > 35 && _playerCard[1] <4)
        {
            return 1;
        }
        if (_playerCard[0] < 4)
        {
            return _playerCard[1] > 35 ? 3 : 2;
        }

        return 0;
    }
}
