using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmikuCsharp.domain
{
    public class LotteryService
    {
        public static String Lottery()
        {
            var random = new Random();
            FortuneModel model = GetFortune(random.Next(0, 7));
            return model.Name;
        }

        public static FortuneModel GetFortune(int id)
        {
            switch (id)
            {
                case 0:
                    return FortuneModel.DAIKICHI;
                case 1:
                    return FortuneModel.CHUUKICHI;
                case 2:
                    return FortuneModel.KICHI;
                case 3:
                    return FortuneModel.SHOUKICHI;
                case 4:
                    return FortuneModel.SUEKICHI;
                case 5:
                    return FortuneModel.KYOU;
                case 6:
                    return FortuneModel.DAIKYOU;
                default:
                    throw new ArgumentException("Invalid id");
            }
        }
    }
}
