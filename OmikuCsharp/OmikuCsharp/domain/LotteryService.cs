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
            FortuneModel model = FortuneModel.GetFortune(random.Next(0, 7));
            return model.Name;
        }
    }
}
