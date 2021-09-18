using System;
using System.Globalization;

namespace now
{
    internal class Program
    {
        public static string[] 干支 = { "甲子", "乙丑", "丙寅", "丁卯", "戊辰", "己巳", "庚午", "辛未", "壬申", "癸酉", "甲戌", "乙亥", "丙子", "丁丑", "戊寅", "己卯", "庚辰", "辛巳", "壬午", "癸未", "甲申", "乙酉", "丙戌", "丁亥", "戊子", "己丑", "庚寅", "辛卯", "壬辰", "癸巳", "甲午", "乙未", "丙申", "丁酉", "戊戌", "己亥", "庚子", "辛丑", "壬寅", "癸卯", "甲辰", "乙巳", "丙午", "丁未", "戊申", "己酉", "庚戌", "辛亥", "壬子", "癸丑", "甲寅", "乙卯", "丙辰", "丁巳", "戊午", "己未", "庚申", "辛酉", "壬戌", "癸亥" };
        public static string[] 生肖 = { "鼠", "牛", "虎", "兔", "龙", "蛇", "马", "羊", "猴", "鸡", "狗", "猪" };
        public static string[,] 月干支 = {
                {"丙寅","丁卯","戊辰","己巳","庚午","辛未","壬申","癸酉","甲戌","乙亥","丙子","丁丑" },
                {"戊寅","己卯","庚辰","辛巳","壬午","癸未","甲申","乙酉","丙戌","丁亥","戊子","己丑" },
                {"庚寅","辛卯","壬辰","癸巳","甲午","乙未","丙申","丁酉","戊戌","己亥","庚子","辛丑"},
                {"壬寅","癸卯","甲辰","乙巳","丙午","丁未","戊申","己酉","庚戌","辛亥","壬子","癸丑" },
                {"甲寅","乙卯","丙辰","丁巳","戊午","己未","庚申","辛酉","壬戌","癸亥","甲子","乙丑" }
                };
        public static string getGanzhiRiBySolar(int year,int month,int day)
        {
            int[] 月基数 = { 0, 0, 31, -1, 30, 0, 31, 1, 32, 3, 33, 4, 34 };
            int[] 世纪常数 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 47, 31, 15, 0, 44, 28, 12, 57, 41 };
            int s = int.Parse(year.ToString().Substring(year.ToString().Length - 2, 2)) - 1;
            int s4 = s / 4;
            
            if(year.ToString().Substring(year.ToString().Length - 2,2) == "00")
            {
                s4 = -1;
            }
            int u = s % 4;
            int x = 世纪常数[int.Parse(year.ToString().Substring(0, year.ToString().Length - 2)) + 1];
            int m = 月基数[month];

            int r = s4 * 6 + 5 * (s4 * 3 + u) + m + day + x;
            
            r = r % 60 - 1;
            
            if((year % 100 != 0 && year % 4 == 0) || (year % 400 == 0))
            {
                if (month > 2) r += 1;
            }
            return 干支[r];
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                ChineseLunisolarCalendar cCalendar = new ChineseLunisolarCalendar();
                DateTime nowDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                int lunarYear = cCalendar.GetYear(nowDate);
                int lunarMonth = cCalendar.GetMonth(nowDate);
                int lunarDay = cCalendar.GetDayOfMonth(nowDate);

                DateTime dt = DateTime.Now;


                // 输出生肖
                Console.Write(生肖[(lunarYear - 1996) % 12]);
                Console.Write(" ");

                // 输出干支
                string ganzhi_nian = 干支[cCalendar.GetSexagenaryYear(dt) - 1];
                Console.Write(ganzhi_nian);
                
                switch (ganzhi_nian[0])
                {
                    case '甲':case '已':
                        Console.Write(月干支[0,lunarMonth-1]);
                        break;
                    case '乙': case '庚':
                        Console.Write(月干支[1, lunarMonth - 1]);
                        break;
                    case '丙': case '辛':
                        Console.Write(月干支[2, lunarMonth - 1]);
                        break;
                    case '丁': case '壬':
                        Console.Write(月干支[3, lunarMonth - 1]);
                        break;
                    case '戊': case '癸':
                        Console.Write(月干支[4, lunarMonth - 1]);
                        break;
                }

                Console.Write(getGanzhiRiBySolar(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day));

                Console.WriteLine();
                // 输出公历
                Console.WriteLine("公历: " + dt.ToString("yyyy-MM-dd HH:mm:ss dddd"));
                
                
                // 输出农历
                Console.WriteLine("农历：" + String.Format("{0}-{1}-{2}",lunarYear,lunarMonth,lunarDay));
            }
            else
            {
                
            }
        }
    }
}
