using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace Common.UI
{
    static class MyUICompnentCreator
    {
        static public LoopScrollView AddLoopScrollView(Transform uibase, string scrollPath, string contentPath, string itemPath, int itemCnt, int scrollListLength, Action<int, GameObject> callBack = null, float pad = 10)
        {
            Transform scroll = TransformHelper.GetCompnent<Transform>(uibase, scrollPath);
            Transform content = TransformHelper.GetCompnent<Transform>(uibase, contentPath);
            Transform item = TransformHelper.GetCompnent<Transform>(uibase, itemPath);
            item.gameObject.SetActive(false);
            if (scroll == null || content == null || item == null)
            {
                Debug.LogError("Common.UI.MyUICompnentCreator : 路径错误，找不到组件");
                return null;
            }
            scroll.AddComponent<RectMask2D>();
            scroll.AddComponent<UnityEngine.UI.Image>().color = new Color(0,0,0,0);
            var loopList = scroll.AddComponent<LoopScrollView>();
            loopList.AddScrollView(item, content, itemCnt, scrollListLength, callBack, pad);
            return loopList;
        }
    }

    class LoopScrollView : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        public RectTransform cotent;
        public List<RectTransform> items = new List<RectTransform>();
        public float fixSpeed = 800.0f;
        private float pad = 0;
        private Action<int, GameObject> _callBack;

        private Transform _item;
        private Transform _parent;
        private int _itemCount = 5;
        private int _listLength = 10;
        private float scrollHight;

        RectTransform curFirstItem;
        int curFirstItemIndex = 0;
        int curFirstIndex = 0;
        RectTransform curLastItem;
        int curLastItemIndex = 0;
        int curLastIndex = 0;

        float itemHight;
        float itemWidth;

        float offset;
        float lastPos;

        private void Awake()
        {
            scrollHight = GetComponent<RectTransform>().rect.height;
        }

        public void AddScrollView(Transform item, Transform parent, int itemCnt = 0, int listLength = 0, Action<int, GameObject> callBack = null, float pad = 0)
        {
            _item = item;
            _parent = parent;
            _itemCount = itemCnt;
            _listLength = listLength;
            this.pad = pad;
            _callBack = callBack;

            var itemRect = item.GetComponent<RectTransform>();
            itemHight = itemRect.rect.height;
            itemWidth = itemRect.rect.width;

            if(_itemCount == 0)
            {
                _itemCount = Mathf.CeilToInt(scrollHight/(itemHight + pad)) + 1;
            }
            if (_listLength < _itemCount) 
            {
                _itemCount = _listLength;
            }
            if (_itemCount <= 0)
            {
                Debug.LogWarning("循环列表为空");
                return;
            }

            InitItem();

            curLastItemIndex = items.Count - 1;
            curLastIndex = items.Count - 1;
            curLastItem = items[curLastItemIndex];

            curFirstItemIndex = 0;
            curFirstIndex = 0;
            curFirstItem = items[curFirstItemIndex];
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            StopAllCoroutines();
            lastPos = eventData.position.y;
        }

        public void OnDrag(PointerEventData eventData)
        {
            offset = eventData.position.y - lastPos;
            lastPos = eventData.position.y;
            for (int i = 0; i < items.Count; i++)
            {
                items[i].localPosition += Vector3.up * offset;
            }

            if (offset > 0)
            {
                if (curLastIndex < _listLength - 1 && curFirstItem.localPosition.y >= itemHight)
                {
                    int tailPos = (curFirstItemIndex + items.Count - 1) % items.Count;
                    curFirstItem.localPosition = new Vector3(0, items[tailPos].localPosition.y - itemHight - pad, 0);

                    curLastItemIndex = curFirstItemIndex;
                    curLastItem = items[curLastItemIndex];
                    curLastIndex++;

                    curFirstItemIndex = (curFirstItemIndex + 1) % items.Count;
                    curFirstItem = items[curFirstItemIndex];
                    curFirstIndex++;

                    if (_callBack != null)
                    {
                        _callBack(curLastIndex, curLastItem.gameObject);
                    }
                }
            }
            else if (offset < 0)
            {
                if (curFirstIndex > 0 && curFirstItem.localPosition.y <= 0)
                {
                    int headPos = (curLastItemIndex + 1) % items.Count;
                    curLastItem.localPosition = new Vector3(0, items[headPos].localPosition.y + itemHight + pad, 0);

                    curFirstItemIndex = curLastItemIndex;
                    curFirstItem = items[curFirstItemIndex];
                    curFirstIndex--;

                    curLastItemIndex = (curLastItemIndex + items.Count - 1) % items.Count;
                    curLastItem = items[curLastItemIndex];
                    curLastIndex--;

                    if (_callBack != null)
                    {
                        _callBack(curFirstIndex, curFirstItem.gameObject);
                    }
                }
            }
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            StartCoroutine(BackToStartPos());
        }

        private void InitItem()
        {
            for (int i = 0; i < _itemCount; i++)
            {
                var item = Instantiate<GameObject>(_item.gameObject, _parent.transform);
                item.SetActive(true);
                var itemRect = item.GetComponent<RectTransform>();
                itemRect.pivot = new Vector2(0, 1);
                itemRect.localPosition = new Vector3(0,  - i * (itemHight + pad), 0);
                items.Add(itemRect);

                if (_callBack != null)
                {
                    _callBack(i, item);
                }
            }
        }
        public void RefreshList(bool resetPos)
        {
            if (items.Count == 0) return;
            if (resetPos)
            {
                for (int i = 0; i < _itemCount; i++)
                {
                    var item = items[i];
                    var itemRect = item.GetComponent<RectTransform>();
                    itemRect.localPosition = new Vector3(0, -i * (itemHight + pad), 0);

                    if (_callBack != null)
                    {
                        _callBack(i, item.gameObject);
                    }
                }
                curLastItemIndex = items.Count - 1;
                curLastIndex = items.Count - 1;
                curLastItem = items[curLastItemIndex];

                curFirstItemIndex = 0;
                curFirstIndex = 0;
                curFirstItem = items[curFirstItemIndex];
            }
            if (_callBack != null)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    _callBack(i, items[(curFirstItemIndex + i)%items.Count].gameObject);
                }
            }
        }

        public void AddItem()
        {
            if ( itemHight * items.Count + pad * (items.Count-1) < scrollHight + itemHight + pad)
            {
                var item = Instantiate<GameObject>(_item.gameObject, _parent.transform);
                item.SetActive(true);
                var itemRect = item.GetComponent<RectTransform>();
                itemRect.pivot = new Vector2(0, 1);
                itemRect.localPosition = new Vector3(0, -items.Count * (itemHight + pad), 0);
                items.Add(itemRect);

                curLastItem = itemRect;
                curLastItemIndex= items.Count-1;
                curLastIndex = items.Count - 1;

                if (curFirstItem == null)
                {
                    curFirstIndex = 0;
                    curFirstItemIndex = 0;
                    curFirstItem = itemRect;
                }

                if (_callBack != null)
                {
                    _callBack(curFirstIndex + items.Count - 1, item);
                }
            }
        }

        IEnumerator BackToStartPos()
        {
            if (curFirstIndex == 0 && curFirstItem.localPosition.y < 0)
            {
                while (curFirstItem.localPosition.y < 0)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        items[i].localPosition += Vector3.up * Time.deltaTime * fixSpeed;
                    }
                    yield return null;
                }
            }
            else if (curFirstIndex == 0 && curLastIndex == _listLength - 1 && curFirstItem.localPosition.y > 0 && -curLastItem.localPosition.y + itemHight < scrollHight)
            {
                while (curFirstItem.localPosition.y > 0)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        items[i].localPosition -= Vector3.up * Time.deltaTime * fixSpeed;
                    }
                    yield return null;
                }
            }
            else if (curFirstIndex != 0 && curLastIndex == _listLength - 1 && -curLastItem.localPosition.y + itemHight  < scrollHight)
            {
                while (-curLastItem.localPosition.y + itemHight  < scrollHight)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        items[i].localPosition -= Vector3.up * Time.deltaTime * fixSpeed;
                    }
                    yield return null;
                }
            }
        }

        internal void SetListLength(int listLength)
        {
            if (listLength < items.Count)
            {
                for (int i = items.Count-1; i > listLength - 1; i--)
                {
                    Destroy(items[i].gameObject);
                    items.RemoveAt(i);
                    _itemCount--;
                }
                curFirstIndex = 0;
                curFirstItemIndex = 0;
                curFirstItem = items.Count>0 ? items[0] : null;
                if (_itemCount > 0) StartCoroutine(BackToStartPos());
            }
            else if (listLength > items.Count)
            {
                int more = listLength - items.Count;
                for (int i = 0; i < more; i++)
                {
                    AddItem();
                  }
            }
            _listLength = listLength;
        }
    }
}