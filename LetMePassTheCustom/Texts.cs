using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetMePassTheCustom
{
    static class Texts
    {
        public static string gameguide = "以下為一個模擬機場，請用方向鍵控制腳色移動，\r\n在時間內依出境流程與玩家狀態，跑過所有的關卡。\r\n"+
            "只有碰到正確的下一關關卡才會觸發!\r\n遊戲中還會有一些突發事件造成時間加減，也許你抽到的道具可以解決危機。\r\n"+
            "隨機事件與道具和玩家狀態會顯現在視窗頂部。\r\n請按遊戲說明開啟或關閉本說明。";
        public static string Introduction =
            "本遊戲會幫助那些沒出過國的人熟悉出國應該注意的細節，例如：\n" +
            "飛機違禁管制品，出國前必須跑過的行政文件，還有在機場內如何\n" +
            "行動等。玩過幾遍這款遊戲，相信你不再害怕繁雜的出國準備手續！\n";
        public static string ApplyForPassport =
            "假設你預定要在8 月 1 日出國，請問：\n"+
            "護照的有效期限「最快」超過哪天，就必須要重新申請新的？";
        public static string[] condit = new string[3] { "你超容易餓。",
            "天氣不佳，班機延遲，",
            "機場的文書用品補充很遲。" };
        public static string[] mag = new string[3] {"麵包","十元藍筆","快速通關護照" };
        
    }
}
