namespace EM
{
    public static class Initialization
    {
        public static List<Analysis> oneNumber()
        {
            var res = new List<Analysis>();
            for (byte i = 1; i < 51; i++)
            {
                var arr = new byte[1];
                arr[0] = i;
                var analysis = new Analysis(arr, false);
                res.Add(analysis);
            }
            return res;
        }
        public static List<Analysis> twoNumber()
        {
            var res = new List<Analysis>();
            for (byte i = 1; i < 51; i++)
            {
                var arr = new byte[2];
                arr[0] = i;
                for (byte j = (byte)(i + 1); j < 51; j++)
                {
                    arr[1] = j;
                    var analysis = new Analysis((byte[])arr.Clone(), false);
                    res.Add(analysis);
                }
            }
            return res;
        }
        public static List<Analysis> threeNumber()
        {
            var res = new List<Analysis>();
            for (byte i = 1; i < 51; i++)
            {
                var arr = new byte[3];
                arr[0] = i;
                for (byte j = (byte)(i + 1); j < 51; j++)
                {
                    arr[1] = j;
                    for (byte k = (byte)(j + 1); k < 51; k++)
                    {
                        arr[2] = j;
                        var analysis = new Analysis((byte[])arr.Clone(), false);
                        res.Add(analysis);
                    }
                }
            }
            return res;
        }
        public static List<Analysis> fourNumber()
        {
            var res = new List<Analysis>();
            for (byte i = 1; i < 51; i++)
            {
                var arr = new byte[4];
                arr[0] = i;
                for (byte j = (byte)(i + 1); j < 51; j++)
                {
                    arr[1] = j;
                    for (byte k = (byte)(j + 1); k < 51; k++)
                    {
                        arr[2] = k;
                        for (byte l = (byte)(k + 1); l < 51; l++)
                        {
                            arr[3] = l;
                            var analysis = new Analysis((byte[])arr.Clone(), false);
                            res.Add(analysis);
                        }
                    }
                }
            }
            return res;
        }
        public static void fiveNumber(List<CsvData> data)
        {
            for (byte i = 1; i < 51; i++)
            {
                var arr = new byte[5];
                arr[0] = i;
                for (byte j = (byte)(i + 1); j < 51; j++)
                {
                    arr[1] = j;
                    for (byte k = (byte)(j + 1); k < 51; k++)
                    {
                        arr[2] = k;
                        for (byte l = (byte)(k + 1); l < 51; l++)
                        {
                            arr[3] = l;
                            for (byte m = (byte)(l + 1); m < 51; m++)
                            {
                                arr[4] = m;
                                var analysis = new Analysis((byte[])arr.Clone(), false);
                                analysis.checkForResults(data);
                                analysis.calculatePercentages(data.Count);
                                DataAccess.writeDataSqlFiveNum(new List<Analysis> { analysis }, "FiveNumbers");
                            }
                        }
                    }
                }
            }
        }

        public static List<Analysis> oneStar()
        {
            var res = new List<Analysis>();
            for (byte i = 1; i < 13; i++)
            {
                var arr = new byte[1];
                arr[0] = i;
                var analysis = new Analysis((byte[])arr.Clone(), true);
                res.Add(analysis);
            }
            return res;
        }

        public static List<Analysis> twoStar(List<CsvData> data)
        {
            var res = new List<Analysis>();
            for (byte i = 1; i < 13; i++)
            {
                var arr = new byte[2];
                arr[0] = i;
                for (byte j = (byte)(i + 1); j < 13; j++)
                {
                    arr[1] = j;
                    var analysis = new Analysis((byte[])arr.Clone(), true);
                    analysis.checkForResults(data);
                    analysis.calculatePercentages(data.Count);
                    DataAccess.writeDataSqlTwoStar(new List<Analysis> { analysis }, "TwoStars");
                }
            }
            return res;
        }

        public static List<Analysis> oneNumberOneStar()
        {
            var res = new List<Analysis>();
            for (byte i = 1; i < 51; i++)
            {
                var n = new byte[1];
                n[0] = i;
                for (byte j = 1; j < 13; j++)
                {
                    var s = new byte[1];
                    s[0] = j;
                    var analysis = new Analysis((byte[])n.Clone(), (byte[])s.Clone());
                    res.Add(analysis);
                }
            }
            return res;
        }

        public static List<Analysis> twoNumberOneStar()
        {
            var res = new List<Analysis>();
            for (byte i = 1; i < 51; i++)
            {
                var n = new byte[2];
                n[0] = i;
                for (byte j = (byte)(i + 1); j < 51; j++)
                {
                    n[1] = j;
                    for (byte k = 1; k < 13; k++)
                    {
                        var s = new byte[1];
                        s[0] = k;
                        var analysis = new Analysis((byte[])n.Clone(), (byte[])s.Clone());
                        res.Add(analysis);
                    }
                }
            }
            return res;
        }

        public static List<Analysis> threeNumberOneStar()
        {
            var res = new List<Analysis>();
            for (byte i = 1; i < 51; i++)
            {
                var n = new byte[3];
                n[0] = i;
                for (byte j = (byte)(i + 1); j < 51; j++)
                {
                    n[1] = j;
                    for (byte k = (byte)(j + 1); k < 51; k++)
                    {
                        n[2] = k;
                        for (byte l = 1; l < 13; l++)
                        {
                            var s = new byte[1];
                            s[0] = l;
                            var analysis = new Analysis((byte[])n.Clone(), (byte[])s.Clone());
                            res.Add(analysis);
                        }
                    }
                }

            }
            return res;
        }

        public static List<Analysis> fourNumberOneStar()
        {
            var res = new List<Analysis>();
            for (byte i = 1; i < 51; i++)
            {
                var n = new byte[4];
                n[0] = i;
                for (byte j = (byte)(i + 1); j < 51; j++)
                {
                    n[1] = j;
                    for (byte k = (byte)(j + 1); k < 51; k++)
                    {
                        n[2] = k;
                        for (byte l = (byte)(k + 1); l < 51; l++)
                        {
                            n[3] = l;
                            for (byte m = 1; m < 13; m++)
                            {
                                var s = new byte[1];
                                s[0] = m;
                                var analysis = new Analysis((byte[])n.Clone(), (byte[])s.Clone());
                                res.Add(analysis);
                            }
                        }
                    }
                }

            }
            return res;
        }
        public static List<Analysis> oneNumberTwoStar()
        {
            var res = new List<Analysis>();
            for (byte i = 1; i < 51; i++)
            {
                var n = new byte[1];
                n[0] = i;
                for (byte j = 1; j < 13; j++)
                {
                    var s = new byte[2];
                    s[0] = j;
                    for (byte k = (byte)(j + 1); k < 13; k++)
                    {
                        s[1] = k;
                        var analysis = new Analysis((byte[])n.Clone(), (byte[])s.Clone());
                        res.Add(analysis);
                    }
                }
            }
            return res;
        }

        public static List<Analysis> twoNumberTwoStar()
        {
            var res = new List<Analysis>();
            for (byte i = 1; i < 51; i++)
            {
                var n = new byte[2];
                n[0] = i;
                for (byte j = (byte)(i + 1); j < 51; j++)
                {
                    n[1] = j;
                    for (byte k = 1; k < 13; k++)
                    {
                        var s = new byte[2];
                        s[0] = k;
                        for (byte l = (byte)(k + 1); l < 13; l++)
                        {
                            s[1] = l;
                            var analysis = new Analysis((byte[])n.Clone(), (byte[])s.Clone());
                            res.Add(analysis);
                        }

                    }
                }
            }
            return res;
        }

        public static List<Analysis> threeNumberTwoStar()
        {
            var res = new List<Analysis>();
            for (byte i = 1; i < 51; i++)
            {
                var n = new byte[3];
                n[0] = i;
                for (byte j = (byte)(i + 1); j < 51; j++)
                {
                    n[1] = j;
                    for (byte k = (byte)(j + 1); k < 51; k++)
                    {
                        n[2] = k;
                        for (byte l = 1; l < 13; l++)
                        {
                            var s = new byte[2];
                            s[0] = l;
                            for (byte m = (byte)(l + 1); m < 13; m++)
                            {
                                s[1] = m;
                                var analysis = new Analysis((byte[])n.Clone(), (byte[])s.Clone());
                                res.Add(analysis);

                            }
                        }
                    }
                }

            }
            return res;
        }

        public static List<Analysis> fourNumberTwoStar()
        {
            var res = new List<Analysis>();
            for (byte i = 1; i < 51; i++)
            {
                var n = new byte[4];
                n[0] = i;
                for (byte j = (byte)(i + 1); j < 51; j++)
                {
                    n[1] = j;
                    for (byte k = (byte)(j + 1); k < 51; k++)
                    {
                        n[2] = k;
                        for (byte l = (byte)(k + 1); l < 51; l++)
                        {
                            n[3] = l;
                            for (byte m = 1; m < 13; m++)
                            {
                                var s = new byte[2];
                                s[0] = m;
                                for (byte a = (byte)(m + 1); a < 13; a++)
                                {
                                    s[1] = a;
                                    var analysis = new Analysis((byte[])n.Clone(), (byte[])s.Clone());
                                    res.Add(analysis);
                                }
                            }
                        }
                    }
                }

            }
            return res;
        }
    }
}