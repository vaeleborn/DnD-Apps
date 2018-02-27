using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CreatureScaling
{
   
    enum CHALLENGE_RATING { EIGHTH = 1, QUARTER, HALF, ONE, TWO, THREE, FOUR,
                    FIVE, SIX, SEVEN, EIGHT, NINE, TEN, ELEVEN, TWELVE, THIRTEEN,
                    FOURTEEN, FIFTEEN, SIXTEEN, SEVENTEEN, EIGHTEEN, NINETEEN,
                    TWENTY, TWENTY_ONE, TWENTY_TWO, TWENTY_THREE, TWENTY_FOUR,
                    TWENTY_FIVE, TWENTY_SIX, TWENTY_SEVEN, TWENTY_EIGHT,
                    TWENTY_NINE, THIRTY, INVALID};
    class Creature
    {
        public CHALLENGE_RATING CR;
        public int ProfBonus;
        public int ArmorClass;
        public int HitPoints;
        public int AttackBonus;
        public int DmgPerRound;
        public int SaveDC;
        public int Experience;

        static Random rnd;

        static public void Seed()
        {
            rnd = new Random();
        }
        public static Creature NewCR(CHALLENGE_RATING challenge)
        {  
                int prof = 0;
                int ac = 0;
                int hp = 0;
                int attack = 0;
                int dmg = 0;
                int save = 0;
                int xp = 0;

                switch (challenge)
                {
                    case CHALLENGE_RATING.EIGHTH:
                        prof = 2;
                        ac = 13;
                        hp = rnd.Next(7, 36);
                        attack = 3;
                        dmg = rnd.Next(2, 4);
                        save = 13;
                        xp = 25;
                        break;

                    case CHALLENGE_RATING.QUARTER:
                        prof = 2;
                        ac = 13;
                        hp = rnd.Next(36, 50);
                        attack = 3;
                        dmg = rnd.Next(4, 6);
                        save = 13;
                        xp = 50;
                        break;

                    case CHALLENGE_RATING.HALF:
                        prof = 2;
                        ac = 13;
                        hp = rnd.Next(50, 71);
                        attack = 3;
                        dmg = rnd.Next(6, 9);
                        save = 13;
                        xp = 100;
                        break;

                    case CHALLENGE_RATING.ONE:
                        prof = 2;
                        ac = 13;
                        hp = rnd.Next(71, 86);
                        attack = 3;
                        dmg = rnd.Next(9, 15);
                        save = 13;
                        xp = 200;
                        break;

                    case CHALLENGE_RATING.TWO:
                        prof = 2;
                        ac = 13;
                        hp = rnd.Next(86, 101);
                        attack = 3;
                        dmg = rnd.Next(15, 21);
                        save = 13;
                        xp = 450;
                        break;

                    case CHALLENGE_RATING.THREE:
                        prof = 2;
                        ac = 13;
                        hp = rnd.Next(101, 116);
                        attack = 4;
                        dmg = rnd.Next(21, 27);
                        save = 13;
                        xp = 700;
                        break;

                    case CHALLENGE_RATING.FOUR:
                        prof = 2;
                        ac = 14;
                        hp = rnd.Next(116, 131);
                        attack = 5;
                        dmg = rnd.Next(27, 33);
                        save = 13;
                        xp = 1100;
                        break;

                    case CHALLENGE_RATING.FIVE:
                        prof = 3;
                        ac = 15;
                        hp = rnd.Next(131, 146);
                        attack = 6;
                        dmg = rnd.Next(33, 39);
                        save = 14;
                        xp = 1800;
                        break;

                    case CHALLENGE_RATING.SIX:
                        prof = 3;
                        ac = 15;
                        hp = rnd.Next(146, 161);
                        attack = 6;
                        dmg = rnd.Next(39, 45);
                        save = 15;
                        xp = 2300;
                        break;

                    case CHALLENGE_RATING.SEVEN:
                        prof = 3;
                        ac = 15;
                        hp = rnd.Next(161, 176);
                        attack = 6;
                        dmg = rnd.Next(45, 51);
                        save = 15;
                        xp = 2900;
                        break;

                    case CHALLENGE_RATING.EIGHT:
                        prof = 3;
                        ac = 16;
                        hp = rnd.Next(176, 191);
                        attack = 7;
                        dmg = rnd.Next(51, 57);
                        save = 15;
                        xp = 3900;
                        break;

                    case CHALLENGE_RATING.NINE:
                        prof = 4;
                        ac = 16;
                        hp = rnd.Next(191, 205);
                        attack = 7;
                        dmg = rnd.Next(57, 63);
                        save = 16;
                        xp = 5000;
                        break;

                    case CHALLENGE_RATING.TEN:
                        prof = 4;
                        ac = 17;
                        hp = rnd.Next(206, 220);
                        attack = 7;
                        dmg = rnd.Next(63, 69);
                        save = 16;
                        xp = 5900;
                        break;

                    case CHALLENGE_RATING.ELEVEN:
                        prof = 4;
                        ac = 17;
                        hp = rnd.Next(221, 235);
                        attack = 8;
                        dmg = rnd.Next(69, 75);
                        save = 16;
                        xp = 7200;
                        break;

                    case CHALLENGE_RATING.TWELVE:
                        prof = 4;
                        ac = 17;
                        hp = rnd.Next(236, 251);
                        attack = 8;
                        dmg = rnd.Next(75, 81);
                        save = 17;
                        xp = 8400;
                        break;

                    case CHALLENGE_RATING.THIRTEEN:
                        prof = 5;
                        ac = 18;
                        hp = rnd.Next(251, 266);
                        attack = 8;
                        dmg = rnd.Next(81, 87);
                        save = 17;
                        xp = 10000;
                        break;

                    case CHALLENGE_RATING.FOURTEEN:
                        prof = 5;
                        ac = 18;
                        hp = rnd.Next(266, 281);
                        attack = 8;
                        dmg = rnd.Next(87, 93);
                        save = 18;
                        xp = 11500;
                        break;

                    case CHALLENGE_RATING.FIFTEEN:
                        prof = 5;
                        ac = 18;
                        hp = rnd.Next(281, 296);
                        attack = 8;
                        dmg = rnd.Next(93, 99);
                        save = 18;
                        xp = 13000;
                        break;

                    case CHALLENGE_RATING.SIXTEEN:
                        prof = 5;
                        ac = 18;
                        hp = rnd.Next(296, 311);
                        attack = 9;
                        dmg = rnd.Next(99, 105);
                        save = 18;
                        xp = 15000;
                        break;

                    case CHALLENGE_RATING.SEVENTEEN:
                        prof = 6;
                        ac = 19;
                        hp = rnd.Next(311, 326);
                        attack = 10;
                        dmg = rnd.Next(105, 111);
                        save = 18;
                        xp = 18000;
                        break;

                    case CHALLENGE_RATING.EIGHTEEN:
                        prof = 6;
                        ac = 19;
                        hp = rnd.Next(326, 341);
                        attack = 10;
                        dmg = rnd.Next(111, 117);
                        save = 19;
                        xp = 20000;
                        break;

                    case CHALLENGE_RATING.NINETEEN:
                        prof = 6;
                        ac = 19;
                        hp = rnd.Next(341, 356);
                        attack = 10;
                        dmg = rnd.Next(117, 123);
                        save = 19;
                        xp = 22000;
                        break;

                    case CHALLENGE_RATING.TWENTY:
                        prof = 6;
                        ac = 19;
                        hp = rnd.Next(356, 401);
                        attack = 10;
                        dmg = rnd.Next(123, 141);
                        save = 19;
                        xp = 25000;
                        break;

                    case CHALLENGE_RATING.TWENTY_ONE:
                        prof = 7;
                        ac = 19;
                        hp = rnd.Next(401, 446);
                        attack = 11;
                        dmg = rnd.Next(141, 159);
                        save = 19;
                        xp = 33000;
                        break;

                    case CHALLENGE_RATING.TWENTY_TWO:
                        prof = 7;
                        ac = 19;
                        hp = rnd.Next(446, 490);
                        attack = 11;
                        dmg = rnd.Next(159, 177);
                        save = 20;
                        xp = 41000;
                        break;

                    case CHALLENGE_RATING.TWENTY_THREE:
                        prof = 7;
                        ac = 19;
                        hp = rnd.Next(491, 536);
                        attack = 11;
                        dmg = rnd.Next(177, 195);
                        save = 20;
                        xp = 50000;
                        break;

                    case CHALLENGE_RATING.TWENTY_FOUR:
                        prof = 7;
                        ac = 19;
                        hp = rnd.Next(536, 581);
                        attack = 12;
                        dmg = rnd.Next(195, 212);
                        save = 21;
                        xp = 62000;
                        break;

                    case CHALLENGE_RATING.TWENTY_FIVE:
                        prof = 8;
                        ac = 19;
                        hp = rnd.Next(581, 626);
                        attack = 12;
                        dmg = rnd.Next(213, 231);
                        save = 21;
                        xp = 75000;
                        break;

                    case CHALLENGE_RATING.TWENTY_SIX:
                        prof = 8;
                        ac = 19;
                        hp = rnd.Next(626, 671);
                        attack = 12;
                        dmg = rnd.Next(231, 249);
                        save = 21;
                        xp = 90000;
                        break;

                    case CHALLENGE_RATING.TWENTY_SEVEN:
                        prof = 8;
                        ac = 19;
                        hp = rnd.Next(671, 716);
                        attack = 13;
                        dmg = rnd.Next(249, 270);
                        save = 22;
                        xp = 105000;
                        break;

                    case CHALLENGE_RATING.TWENTY_EIGHT:
                        prof = 8;
                        ac = 19;
                        hp = rnd.Next(716, 761);
                        attack = 13;
                        dmg = rnd.Next(267, 285);
                        save = 22;
                        xp = 120000;
                        break;

                    case CHALLENGE_RATING.TWENTY_NINE:
                        prof = 9;
                        ac = 19;
                        hp = rnd.Next(761, 806);
                        attack = 13;
                        dmg = rnd.Next(285, 303);
                        save = 22;
                        xp = 135000;
                        break;

                    case CHALLENGE_RATING.THIRTY:
                        prof = 9;
                        ac = 19;
                        hp = rnd.Next(806, 851);
                        attack = 14;
                        dmg = rnd.Next(303, 321);
                        save = 23;
                        xp = 155000;
                        break;
                    case CHALLENGE_RATING.INVALID:
                    prof = 0;
                    ac = 0;
                    hp = 0;
                    attack = 0;
                    dmg = 0;
                    save = 0;
                    xp = 0;
                        break;

                    default:
                        break;
                }

                return new Creature(challenge, prof, ac, hp, attack, dmg, save, xp);   
        }

        public Creature(CHALLENGE_RATING cr, int profBonus, int ac, int hp,
            int attackBonus, int dmg, int save, int xp)
        {
            CR = cr;
            ProfBonus = profBonus;
            ArmorClass = ac;
            HitPoints = hp;
            AttackBonus = attackBonus;
            DmgPerRound = dmg;
            SaveDC = save;
            Experience = xp;
        }
            
    }
}
