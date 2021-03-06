﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace GameCubeRNG.Objects
{
    public class DisplayList
    {
        public uint Seed { get; set; }

        public uint PID { get; set; }

        public String Shiny { get; set; }

        public String Nature { get; set; }

        public uint Ability { get; set; }

        public uint Hp { get; set; }

        public uint Atk { get; set; }

        public uint Def { get; set; }

        public uint SpA { get; set; }

        public uint SpD { get; set; }

        public uint Spe { get; set; }

        public String Hidden { get; set; }

        public int Power { get; set; }

        public char Eighth { get; set; }

        public char Quarter { get; set; }

        public char Half { get; set; }

        public char Three_Fourths { get; set; }

        public String Reason { get; set; }
    }

    public class ShadowDisplay
    {
        public int Frame { get; set; }

        public uint PID { get; set; }

        public String Nature { get; set; }

        public uint Ability { get; set; }

        public uint Hp { get; set; }

        public uint Atk { get; set; }

        public uint Def { get; set; }

        public uint SpA { get; set; }

        public uint SpD { get; set; }

        public uint Spe { get; set; }

        public String Hidden { get; set; }

        public int Power { get; set; }

        public char Eighth { get; set; }

        public char Quarter { get; set; }

        public char Half { get; set; }

        public char Three_Fourths { get; set; }
    }

    public class IDisplayListComparator : IComparer<DisplayList>
    {
        public String CompareType = "Seed";
        public SortOrder sortOrder = SortOrder.Ascending;

        public int Compare(DisplayList x, DisplayList y)
        {
            int result;
            int direction = 1;

            if (sortOrder == SortOrder.Descending)
                direction = -1;

            switch (CompareType)
            {
                case "Seed":
                    result = direction * x.Seed.CompareTo(y.Seed);
                    return result;
                case "PID":
                    return direction * x.PID.CompareTo(y.PID);
                case "Nature":
                    return direction * Functions.NatureNumber(x.Nature).CompareTo(Functions.NatureNumber(y.Nature));
                case "Ability":
                    return direction * x.Ability.CompareTo(y.Ability);
                case "HP":
                    result = direction * x.Hp.CompareTo(y.Hp);
                    if (result == 0)
                    {
                        result = direction * x.Atk.CompareTo(y.Atk);
                        if (result == 0)
                        {
                            result = direction * x.Def.CompareTo(y.Def);
                            if (result == 0)
                            {
                                result = direction * x.SpA.CompareTo(y.SpA);
                                if (result == 0)
                                {
                                    result = direction * x.SpD.CompareTo(y.SpD);
                                    if (result == 0)
                                    {
                                        result = direction * x.Spe.CompareTo(y.Spe);
                                    }
                                }
                            }
                        }
                    }
                    return result;
                case "Atk":
                    result = direction * x.Atk.CompareTo(y.Atk);
                    if (result == 0)
                    {
                        result = direction * x.Hp.CompareTo(y.Hp);
                        if (result == 0)
                        {
                            result = direction * x.Def.CompareTo(y.Def);
                            if (result == 0)
                            {
                                result = direction * x.SpA.CompareTo(y.SpA);
                                if (result == 0)
                                {
                                    result = direction * x.SpD.CompareTo(y.SpD);
                                    if (result == 0)
                                    {
                                        result = direction * x.Spe.CompareTo(y.Spe);
                                    }
                                }
                            }
                        }
                    }
                    return result;
                case "Def":
                    result = direction * x.Def.CompareTo(y.Def);
                    if (result == 0)
                    {
                        result = direction * x.Hp.CompareTo(y.Hp);
                        if (result == 0)
                        {
                            result = direction * x.Atk.CompareTo(y.Atk);
                            if (result == 0)
                            {
                                result = direction * x.SpA.CompareTo(y.SpA);
                                if (result == 0)
                                {
                                    result = direction * x.SpD.CompareTo(y.SpD);
                                    if (result == 0)
                                    {
                                        result = direction * x.Spe.CompareTo(y.Spe);
                                    }
                                }
                            }
                        }
                    }
                    return result;
                case "SpA":
                    result = direction * x.SpA.CompareTo(y.SpA);
                    if (result == 0)
                    {
                        result = direction * x.Hp.CompareTo(y.Hp);
                        if (result == 0)
                        {
                            result = direction * x.Atk.CompareTo(y.Atk);
                            if (result == 0)
                            {
                                result = direction * x.Def.CompareTo(y.Def);
                                if (result == 0)
                                {
                                    result = direction * x.SpD.CompareTo(y.SpD);
                                    if (result == 0)
                                    {
                                        result = direction * x.Spe.CompareTo(y.Spe);
                                    }
                                }
                            }
                        }
                    }
                    return result;
                case "SpD":
                    result = direction * x.SpD.CompareTo(y.SpD);
                    if (result == 0)
                    {
                        result = direction * x.Hp.CompareTo(y.Hp);
                        if (result == 0)
                        {
                            result = direction * x.Atk.CompareTo(y.Atk);
                            if (result == 0)
                            {
                                result = direction * x.Def.CompareTo(y.Def);
                                if (result == 0)
                                {
                                    result = direction * x.SpA.CompareTo(y.SpA);
                                    if (result == 0)
                                    {
                                        result = direction * x.Spe.CompareTo(y.Spe);
                                    }
                                }
                            }
                        }
                    }
                    return result;
                case "Spe":
                    result = direction * x.Spe.CompareTo(y.Spe);
                    if (result == 0)
                    {
                        result = direction * x.Hp.CompareTo(y.Hp);
                        if (result == 0)
                        {
                            result = direction * x.Atk.CompareTo(y.Atk);
                            if (result == 0)
                            {
                                result = direction * x.Def.CompareTo(y.Def);
                                if (result == 0)
                                {
                                    result = direction * x.SpA.CompareTo(y.SpA);
                                    if (result == 0)
                                    {
                                        result = direction * x.SpD.CompareTo(y.SpD);
                                    }
                                }
                            }
                        }
                    }
                    return result;
                case "Power":
                    return direction * x.Power.CompareTo(y.Power);
                default:
                    //use ordinal due to better efficiency and because it uses the current culture
                    result = direction *
                             String.CompareOrdinal(x.GetType().GetProperty(CompareType).GetValue(x, null).ToString(),
                                                   y.GetType().GetProperty(CompareType).GetValue(y, null).ToString());

                    return result;
            }
        }

    }
}
