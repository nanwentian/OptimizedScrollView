﻿/**　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　
*　　　　　　　　　瓦瓦　　　　　　　　　　　　十　　　　　　　　　　　　　
*　　　　　　　　十齱龠己　　　　　　　　　亅瓦車己　　　　　　　　　　　　
*　　　　　　　　乙龍龠毋日丶　　　　　　丶乙己毋毋丶　　　　　　　　　　　
*　　　　　　　　十龠馬鬼車瓦　　　　　　己十瓦毋毋　　　　　　　　　　　　
*　　　　　　　　　鬼馬龠馬龠十　　　　己己毋車毋瓦　　　　　　　　　　　　
*　　　　　　　　　毋龠龠龍龠鬼乙丶丶乙車乙毋鬼車己　　　　　　　　　　　　
*　　　　　　　　　乙龠龍龍鬼龍瓦　十瓦毋乙瓦龠瓦亅　　　　　　　　　　　　
*　　　　　　　　　　馬齱龍馬鬼十丶日己己己毋車乙丶　　　　　　　　　　　　
*　　　　　　　　　　己齱馬鬼車十十毋日乙己己乙乙　　　　　　　　　　　　　
*　　　　　　　　　　　車馬齱齱日乙毋瓦己乙瓦日亅　　　　　　　　　　　　　
*　　　　　　　　　　　亅車齺龖瓦乙車龖龍乙乙十　　　　　　　　　　　　　　
*　　　　　　　　　　　　日龠龠十亅車龍毋十十　　　　　　　　　　　　　　　
*　　　　　　　　　　　　日毋己亅　己己十亅亅　　　　　　　　　　　　　　　
*　　　　　　　　　　　丶己十十乙　　丶丶丶丶丶　　　　　　　　　　　　　　
*　　　　　　　　　　　亅己十龍龖瓦　　丶　丶　乙十　　　　　　　　　　　　
*　　　　　　　　　　　亅己十龠龖毋　丶丶　　丶己鬼鬼瓦亅　　　　　　　　　
*　　　　　　　　　　　十日十十日亅丶亅丶　丶十日毋鬼馬馬車乙　　　　　　　
*　　　　　　　　　　　十日乙十亅亅亅丶　　十乙己毋鬼鬼鬼龍齺馬乙　　　　　
*　　　　　　　　　　　丶瓦己乙十十亅丶亅乙乙乙己毋鬼鬼鬼龍齱齺齺鬼十　　　
*　　　　　　　　　　　　乙乙十十十亅乙瓦瓦己日瓦毋鬼鬼龠齱齱龍龍齱齱毋丶　
*　　　　　　　　　　　　亅十十十十乙瓦車毋瓦瓦日車馬龠龍龍龍龍龍龠龠龠馬亅
*　　　　　　　　　　　　　十十十十己毋車瓦瓦瓦瓦鬼馬龠龍龠龠龍龠龠龠馬龠車
*　　　　　　　　　　　　　　亅十十日毋瓦日日瓦鬼鬼鬼龠龠馬馬龠龍龍龠馬馬車
*　　　　　　　　　　　　　　亅亅亅乙瓦瓦毋車車車馬龍龠鬼鬼馬龠龍龍龠馬馬鬼
*　　　　　　　　　　　　丶丶乙亅亅乙車鬼鬼鬼毋車龍龍龠鬼馬馬龠龍齱齱龍馬鬼
*　　　　　　　　　　　亅己十十己十日鬼鬼車瓦毋龠龍龠馬馬龠龠龠齱齺齺齱龠鬼
*　　　　　　　　　　　　亅乙乙乙十車馬車毋馬齱齱龍龠龠龠馬龠龍齱龍龠龠鬼瓦
*　　　　　　　　　　　　　　　　丶毋龠鬼車瓦車馬龠龍龠龠龍齱齱龠馬馬鬼毋日
*　　　　　　　　　　　　　　　　十乙己日十　　丶己鬼龍齱齺齱龍馬馬馬車毋己
*　　　　　　　　　　　　　　丶十己乙亅丶　　　　　　亅瓦馬龠龍龠龠馬毋瓦乙
*　　　　　　　　　　　　　丶十十乙亅十　　　　　　　　亅己瓦車馬龠鬼車瓦乙
*　　　　　　　　　　　　　丶十乙十十丶　　　　　　　　　丶丶亅十瓦鬼車瓦己
*　　　　　　　　　　　　　　丶亅亅丶　　　　　　　　　　　　　　　亅日瓦日
*　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　丶
*/
/**
 * <p>文件描述：变高列表<p>
 * <p>作者：NavyZhang<p>
 * <p>创建时间：2018/11/03<p>
 * 
 */
using System.Collections;
using UnityEngine.UI.Extension.Collocation;
using System;

namespace UnityEngine.UI.Extension
{
	public class UISmartScrollView : SmartScrollView<BaseCollocation>
	{
        private IList _datas;
        private GameObject _itemPrefab;
        private Type cellType;

        #region UISmartScrollView implementation
       

        public void UpdateScrollView<T>(IList datas,GameObject prefab,bool isScrollBottom = true)where T: UILoopSmartItem
        {
            if(datas == null || prefab == null)
            {
                Debug.LogError("参数不能为空!!");
                return;
            }
            _datas = datas;
            _itemPrefab = prefab;
            cellType = typeof(T);
            OnItemCountChangeRequested(_datas.Count);
            if(isScrollBottom)
            {
                StopCoroutine("ScrollToBottom");
                StartCoroutine("ScrollToBottom", datas.Count);
            } else
            {
                StopCoroutine("ScrollToUp");
                StartCoroutine("ScrollToUp");
            }
          
        }

        IEnumerator ScrollToUp()
        {
            yield return new WaitForEndOfFrame();
            SmoothScrollTo(0, 0f);
        }
        IEnumerator ScrollToBottom(int count)
        {
            yield return new WaitForEndOfFrame();
            SmoothScrollTo(count - 1, 0f);               
        }
		protected override void Update()
		{
			base.Update();

		}

		protected override UILoopSmartItem CreateCellView(int itemIndex)
		{
            var instance = Activator.CreateInstance(cellType) as UILoopSmartItem;
			instance.Init(_itemPrefab, itemIndex);

			return instance;
		}

		protected override void OnItemHeightChangedPreTwinPass(UILoopSmartItem vh)
		{
			base.OnItemHeightChangedPreTwinPass(vh);
		}

		protected override void UpdateCellView(UILoopSmartItem newOrRecycled)
		{
			newOrRecycled.UpdateFromModel(_datas, newOrRecycled.ItemIndex);

            newOrRecycled.MarkForRebuild();
            ScheduleComputeVisibilityTwinPass(true);


            if (!newOrRecycled.IsPopupAnimationActive && newOrRecycled.cellIndex == GetItemsCount() - 1) 
				newOrRecycled.IsPopupAnimationActive = true;
		}
		protected override void OnBeforeRecycleOrDisableViewsHolder(UILoopSmartItem inRecycleBinOrVisible, int newItemIndex)
		{
			inRecycleBinOrVisible.IsPopupAnimationActive = false;

			base.OnBeforeRecycleOrDisableViewsHolder(inRecycleBinOrVisible, newItemIndex);
		}

		protected override void RebuildLayoutDueToScrollViewSizeChange()
		{
			base.RebuildLayoutDueToScrollViewSizeChange();
		}
		#endregion

		#region events
	    public void AddItemRequested(bool atEnd,int preCount,int count)
		{
			InsertItems(preCount, count, true);
		}
        public void RemoveItemRequested(bool atEnd, int count)
        {
            int index = atEnd ? (_datas.Count - count): 0;
            RemoveItems(index, count, true);
        }
        public void OnItemCountChangeRequested(int newCount)
		{
			ResetItems(_datas.Count, true);
		}
        #endregion
	}

 
}