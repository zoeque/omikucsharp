﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmikuCsharp.domain
{
    public class FortuneModel
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public static readonly FortuneModel DAIKICHI = new FortuneModel(0, "大吉");
        public static readonly FortuneModel CHUUKICHI = new FortuneModel(1, "中吉");
        public static readonly FortuneModel KICHI = new FortuneModel(2, "吉");
        public static readonly FortuneModel SHOUKICHI = new FortuneModel(3, "小吉");
        public static readonly FortuneModel SUEKICHI = new FortuneModel(4, "末吉");
        public static readonly FortuneModel KYOU = new FortuneModel(5, "凶");
        public static readonly FortuneModel DAIKYOU = new FortuneModel(6, "大凶");
        private FortuneModel(int id, string name)
        {
            Id = id;
            Name = name;
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
