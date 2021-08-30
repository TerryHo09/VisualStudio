using System;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PerformanceTest
{
    class MyTest
    {
        private List<String> mList = new List<String>();
        private List<String> mList2 = new List<String>();
        private List<String> mList3 = new List<String>();
        private List<String> mList4 = new List<String>();

        private Stopwatch mSp = new Stopwatch();
        private Stopwatch mSp2 = new Stopwatch();
        private Stopwatch mSp3 = new Stopwatch();
        private Stopwatch mSp4 = new Stopwatch();

        public void Start()
        {
            this.InitList();
            //this.TaskSortAndRefreshChannels();
            //this.TaskSortTest();
            //this.TaskSortTest2();
            this.SortTest();
        }

        private void InitList()
        {
            this.mList.Add("_新人專區");
            this.mList.Add("星城頻道1");
            this.mList.Add("-歐支-");
            this.mList.Add("星城頻道2");
            this.mList.Add("三重超級娃娃");
            this.mList.Add("星城頻道3");
            this.mList.Add("強運專區");
            this.mList.Add("星城頻道4");
            this.mList.Add("正沙合法");
            this.mList.Add("中壢檳榔");
            this.mList.Add("拓海一線");
            this.mList.Add("小小高本尊");
            this.mList.Add("順財小芳");
            this.mList.Add("可比一");
            this.mList.Add("小小妍");
            this.mList.Add("好利發");
            this.mList.Add("發發發金幣");
            this.mList.Add("美可");
            this.mList.Add("寶佳銀行");
            this.mList.Add("溫叨就合雅");
            this.mList.Add("就愛小予");
            this.mList.Add("信託");
            this.mList.Add("六一花店");
            this.mList.Add("星富發");
            this.mList.Add("星麗屋");
            this.mList.Add("大交流屋");
            this.mList.Add("錢樂");
            this.mList.Add("發財服務區");
            this.mList.Add("本尊吉客發");
            this.mList.Add("財神小妞");
            this.mList.Add("發利發");
            this.mList.Add("台中老司機");
            this.mList.Add("客幣發");
            this.mList.Add("彩都");
            this.mList.Add("昇馬銀行");
            this.mList.Add("四方金控");
            this.mList.Add("虎來發");
            this.mList.Add("幸運一個讚");
            this.mList.Add("祝福站");
            this.mList.Add("星船");
            this.mList.Add("立速銀行");
            this.mList.Add("燦坤");
            this.mList.Add("888銀行");
            this.mList.Add("皇海金庫");
            this.mList.Add("曉亮正牌");
            this.mList.Add("誠信在乎");
            this.mList.Add("我是雪夫蘭");
            this.mList.Add("容瑄");
            this.mList.Add("開運金");
            this.mList.Add("以心");
            this.mList.Add("本尊京泰");
            this.mList.Add("財神帝國");
            this.mList.Add("三重快遞");
            this.mList.Add("動物之家本尊");
            this.mList.Add("奪冠本尊");
            this.mList.Add("來來金流");
            this.mList.Add("多分妹");
            this.mList.Add("彩金小妹");
            this.mList.Add("樂貝兒");
            this.mList.Add("上官飛鳳");
            this.mList.Add("開分銀行");
            this.mList.Add("華信家族");
            this.mList.Add("星幣水果大亨");
            this.mList.Add("欣吉");
            this.mList.Add("交流請找寶嬴");
            this.mList.Add("小林幸運幣");
            this.mList.Add("迎分");
            this.mList.Add("小羊商會");
            this.mList.Add("正牌陳鵬");
            this.mList.Add("發張3給她");
            this.mList.Add("富商號");
            this.mList.Add("勤力本人");
            this.mList.Add("吉財");
            this.mList.Add("喜客來");
            this.mList.Add("本尊富帝");
            this.mList.Add("有間漫畫");
            this.mList.Add("稻田");
            this.mList.Add("金馬王朝");
            this.mList.Add("鈞勝");
            this.mList.Add("安風");
            this.mList.Add("新幣卡所");
            this.mList.Add("三重多多");
            this.mList.Add("星際娛樂");
            this.mList.Add("藍曉天");
            this.mList.Add("板橋報紙");
            this.mList.Add("星爺交流");
            this.mList.Add("轉運之星");
            this.mList.Add("星聚點銀行");
            this.mList.Add("丁安安");
            this.mList.Add("本尊大富爺");
            this.mList.Add("金庫國際");
            this.mList.Add("元聚商行");
            this.mList.Add("利澳本尊");
            this.mList.Add("汐止必備金");
            this.mList.Add("羽果");
            this.mList.Add("世貿一館");
            this.mList.Add("天貓金服");
            this.mList.Add("林依潔");
            this.mList.Add("誠信樂趣玩玩");
            this.mList.Add("馬丁洋行");
            this.mList.Add("金雞報囍");
            this.mList.Add("米米家族金庫");
            this.mList.Add("帶財商號");
            this.mList.Add("二二二二福利");
            this.mList.Add("八德小多");
            this.mList.Add("泰東本尊");
            this.mList.Add("服務處");
            this.mList.Add("艾斯銀行");
            this.mList.Add("小昱金庫");
            this.mList.Add("彩鑽俱樂部");
            this.mList.Add("極速雜貨店");
            this.mList.Add("法老王金控");
            this.mList.Add("華金的");
            this.mList.Add("中壢小文");
            this.mList.Add("君品");
            this.mList.Add("就愛打台子");
            this.mList.Add("百發百");
            this.mList.Add("耶輪保佑我");
            this.mList.Add("錢小美");
            this.mList.Add("歡樂發");
            this.mList.Add("星糖糖");
            this.mList.Add("小小商會");
            this.mList.Add("林家檳榔");
            this.mList.Add("沙霸");
            this.mList.Add("運轉一路發");
            this.mList.Add("鬥陣森森");
            this.mList.Add("3隻喵");
            this.mList.Add("幼華金庫");
            this.mList.Add("星宇通");
            this.mList.Add("吉伯億糖果屋");
            this.mList.Add("福勝亭");
            this.mList.Add("童話銀行");
            this.mList.Add("開源號");
            this.mList.Add("維修站");
            this.mList.Add("我是小豬妮子");
            this.mList.Add("維泥泥");
            this.mList.Add("藍印子");
            this.mList.Add("聚財交流");
            this.mList.Add("2021錢莊");
            this.mList.Add("哈乖乖");
            this.mList.Add("芷凌");
            this.mList.Add("沒用翔");
            this.mList.Add("淡淡金清香");
            this.mList.Add("香香來富");
            this.mList.Add("蝶娜");
            this.mList.Add("羽珍");
            this.mList.Add("西瓜芭樂蓮霧");

            this.mList2.AddRange(this.mList);
            this.mList3.AddRange(this.mList);
            this.mList4.AddRange(this.mList);
        }

        private void SortTest()
        {
            this.mSp.Start();
            this.mList.Sort(Compare);
            this.mSp.Stop();

            this.mSp2.Start();
            this.mList2.Sort(Compare2);
            this.mSp2.Stop();

            this.mSp3.Start();
            this.mList3.Sort(Compare3);
            this.mSp3.Stop();

            this.mSp4.Start();
            this.mList4.Sort(Compare4);
            this.mSp4.Stop();

            Debug.Print("t1:" + this.mSp.ElapsedMilliseconds.ToString() + Environment.NewLine +
            "t2:" + this.mSp2.ElapsedMilliseconds.ToString() + Environment.NewLine +
            "t3:" + this.mSp3.ElapsedMilliseconds.ToString() + Environment.NewLine +
            "t4:" + this.mSp4.ElapsedMilliseconds.ToString());
        }

        private  void TaskSortTest()
        {
            this.mSp.Start();
            Task t1 = Task.Run(() =>
            {
                this.mList.Sort(Compare);
            });
            t1.Wait();
            this.mSp.Stop();

            this.mSp2.Start();
            Task t2 = Task.Run(() =>
            {
                this.mList2.Sort(Compare2);
            });
            t2.Wait();
            this.mSp2.Stop();

            this.mSp3.Start();
            Task t3 = Task.Run(() =>
            {
                this.mList3.Sort(Compare3);
            });
            t3.Wait();
            this.mSp3.Stop();

            this.mSp4.Start();
            Task t4 = Task.Run( () =>
            {
                this.mList4.Sort(Compare4);
            });
            t4.Wait();
            this.mSp4.Stop();

            Debug.Print("t1:" + this.mSp.ElapsedMilliseconds.ToString() + Environment.NewLine +
                        "t2:" + this.mSp2.ElapsedMilliseconds.ToString() + Environment.NewLine +
                        "t3:" + this.mSp3.ElapsedMilliseconds.ToString() + Environment.NewLine +
                        "t4:" + this.mSp4.ElapsedMilliseconds.ToString());
        }

        private void TaskSortTest2()
        {
            Task t1 = Task.Run(() =>
            {
                this.mSp.Start();
                this.mList.Sort(Compare);
                this.mSp.Stop();
            });
            
            Task t2 = Task.Run(() =>
            {
                this.mSp2.Start();
                this.mList2.Sort(Compare2);
                this.mSp2.Stop();
            });

            
            Task t3 = Task.Run(() =>
            {
                this.mSp3.Start();
                this.mList3.Sort(Compare3);
                this.mSp3.Stop();
            });

            
            Task t4 = Task.Run(() =>
            {
                this.mSp4.Start();
                this.mList4.Sort(Compare4);
                this.mSp4.Stop();
            });

            Task.WaitAll( t1, t2, t3, t4 );

            Debug.Print("t1:" + this.mSp.ElapsedMilliseconds.ToString() + Environment.NewLine +
                        "t2:" + this.mSp2.ElapsedMilliseconds.ToString() + Environment.NewLine +
                        "t3:" + this.mSp3.ElapsedMilliseconds.ToString() + Environment.NewLine +
                        "t4:" + this.mSp4.ElapsedMilliseconds.ToString());
        }

        private async void SortAndRefreshChannels()
        {
            await this.SortChannelList();
        }

        private async Task SortChannelList()
        {
            Task task = new Task( () => this.mList.Sort( Compare ) );
            Stopwatch sp = new Stopwatch();
            sp.Start();
            task.Start();
            task.Wait();
            sp.Stop();
            Debug.Print("elapse time:" + sp.ElapsedMilliseconds.ToString());
            await task;
        }

        private int Compare( String x, String y )
        {
            if ( x.Trim().StartsWith("*") && !y.Trim().StartsWith("*") )
                return -1;
            if ( !x.Trim().StartsWith("*") && y.Trim().StartsWith("*") )
                return 1;
            if ( x.Trim().StartsWith("*") && y.Trim().StartsWith("*") )
                return 0;

            if ( x.Trim().StartsWith("星城頻道") && !y.Trim().StartsWith("星城頻道") )
                return 1;
            if ( !x.Trim().StartsWith("星城頻道") && y.Trim().StartsWith("星城頻道") )
                return -1;
            if ( x.Trim().StartsWith("星城頻道") && y.Trim().StartsWith("星城頻道") )
                return 0;
            return 0;
        }

        private int Compare2( String x, String y )
        {
            bool a = x.Trim().StartsWith("*");
            bool b = y.Trim().StartsWith("*");
            if (a && !b)
                return -1;
            if (!a && b)
                return 1;
            if (a && b)
                return 0;
            a = x.Trim().StartsWith("星城頻道");
            b = y.Trim().StartsWith("星城頻道");

            if (a && !b)
                return 1;
            if (!a && b)
                return -1;
            if (a && b)
                return 0;
            return 0;
        }

        private int Compare3(String x, String y)
        {
            int r = 0;
            int p = -99;
            for ( int i = 0; i < 1000; i++ )
            {
                p = -99;
                if (x.Trim().StartsWith("*") && !y.Trim().StartsWith("*"))
                    p = -1;
                if (!x.Trim().StartsWith("*") && y.Trim().StartsWith("*"))
                    p = 1;
                if (x.Trim().StartsWith("*") && y.Trim().StartsWith("*"))
                    p = 0;

                if (x.Trim().StartsWith("星城頻道") && !y.Trim().StartsWith("星城頻道"))
                    p = 1;
                if (!x.Trim().StartsWith("星城頻道") && y.Trim().StartsWith("星城頻道"))
                    p = -1;
                if (x.Trim().StartsWith("星城頻道") && y.Trim().StartsWith("星城頻道"))
                    p = 0;
                if (p != -99)
                    r = p;
            }
            return r;
        }

        private int Compare4(String x, String y)
        {
            bool a = x.Trim().StartsWith("*");
            bool b = y.Trim().StartsWith("*");

            int r = 0;
            int p = -99;

            for ( int i = 0; i < 1000; i++ )
            {
                p = -99;
                if (a && !b)
                    p = -1;
                if (!a && b)
                    p = 1;
                if (a && b)
                    p = 0;
                a = x.Trim().StartsWith("星城頻道");
                b = y.Trim().StartsWith("星城頻道");

                if (a && !b)
                    p = 1;
                if (!a && b)
                    p = -1;
                if (a && b)
                    p = 0;

                if (p != -99)
                    r = p;
            }
            return r;
        }
    }
}