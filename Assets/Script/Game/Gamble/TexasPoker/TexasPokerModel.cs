using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum CardType
{
    HighCard = 0,
    OnePair = 1,
    TwoPair = 2,
    ThreeOfAKind = 3,
    Straight = 4,
    Flush = 5,
    FullHouse = 6,
    FourOfAKind = 7,
    StraightFlush = 8,
    RoyalFlush = 9
}

public class TexasPokerModel : BaseModel<TexasPokerModel>
{
    private bool[] _allCards = new bool[52];
    private Dictionary<int, List<int>> _handCard = new Dictionary<int, List<int>>();
    private List<bool> _fold = new List<bool>();
    private int _step = 0;
    private int _playerCnt = 2;
    private int _dealerPos = 0;

    public void InitGame(int playerCnt)
    {
        _step = 0;
        
    }
}
