using CsvHelper.Configuration.Attributes;

namespace EM
{
    public class Analysis
    {
        [Index(0)]
        public byte[]? Numbers { get; set; }
        [Index(1)]
        public byte[]? Stars { get; set; }
        public int HitsZero { get; set; } = 0;
        public int HitsOne { get; set; } = 0;
        public int HitsTwo { get; set; } = 0;
        public int HitsThree { get; set; } = 0;
        public int HitsFour { get; set; } = 0;
        public int HitsFive { get; set; } = 0;
        public int StarsZero { get; set; } = 0;
        public int StarsOne { get; set; } = 0;
        public int StarsTwo { get; set; } = 0;
        [Index(2)]
        public decimal HitsZeroPercentage { get; set; } = 0;
        [Index(3)]
        public decimal HitsOnePercentage { get; set; } = 0;
        [Index(4)]
        public decimal HitsTwoPercentage { get; set; } = 0;
        [Index(5)]
        public decimal HitsThreePercentage { get; set; } = 0;
        [Index(6)]
        public decimal HitsFourPercentage { get; set; } = 0;
        [Index(7)]
        public decimal HitsFivePercentage { get; set; } = 0;
        [Index(8)]
        public decimal StarsZeroPercentage { get; set; } = 0;
        [Index(9)]
        public decimal StarsOnePercentage { get; set; } = 0;
        [Index(10)]
        public decimal StarsTwoPercentage { get; set; } = 0;
        [Index(11)]
        public int LastTimeHit { get; set; }
        public Analysis(byte[] arr, bool starsTrue)
        {
            if (!starsTrue)
            {
                this.Numbers = arr;
            }
            else
            {
                this.Stars = arr;
            }
        }
        public Analysis(byte[] numbers, byte[] stars)
        {
            this.Numbers = numbers;
            this.Stars = stars;
        }

        public void showResult(int count)
        {
            if (this.Numbers != null)
            {
                if (this.Numbers.Length > 1)
                {
                    System.Console.Write("Numbers: [");
                    for (int i = 0; i < this.Numbers.Length - 1; i++)
                    {
                        System.Console.Write($"{this.Numbers[i]}, ");
                    }
                    System.Console.WriteLine($"{this.Numbers.Last()}]");
                }
                else if (this.Numbers.Length == 1)
                {
                    System.Console.WriteLine($"Numbers: [{this.Numbers[0]}]");
                }
            }
            if (this.Stars != null)
            {
                if (this.Stars.Length > 1)
                {
                    System.Console.Write("Stars: [");
                    for (int i = 0; i < this.Stars.Length - 1; i++)
                    {
                        System.Console.Write($"{this.Stars[i]}, ");
                    }
                    System.Console.WriteLine($"{this.Stars.Last()}]");
                }
                else if (this.Stars.Length == 1)
                {
                    System.Console.WriteLine($"Stars: [{this.Stars[0]}]");
                }
            }
            if (this.Numbers != null)
            {
                System.Console.WriteLine($"Zero hit: {this.HitsZeroPercentage}");
                System.Console.WriteLine($"One hit: {this.HitsOnePercentage}");
                System.Console.WriteLine($"Two hit: {this.HitsTwoPercentage}");
                System.Console.WriteLine($"Three hit: {this.HitsThreePercentage}");
                System.Console.WriteLine($"Four hit: {this.HitsFourPercentage}");
                System.Console.WriteLine($"Five hit: {this.HitsFivePercentage}");
            }
            if (this.Stars != null)
            {
                System.Console.WriteLine($"Zero hit (stars): {this.StarsZeroPercentage}");
                System.Console.WriteLine($"One hit (stars): {this.StarsOnePercentage}");
                System.Console.WriteLine($"Two hit (stars): {this.StarsTwoPercentage}");
            }
        }

        public void checkForResults(List<CsvData> data)
        {
            foreach (var d in data)
            {
                if (this.Numbers != null)
                {
                    var count = 0;
                    foreach (var n in this.Numbers)
                    {
                        if (d.Numbers.Contains(n))
                        {
                            count++;
                        }
                    }
                    switch (count)
                    {
                        case 0:
                            this.HitsZero++;
                            break;
                        case 1:
                            this.HitsOne++;
                            break;
                        case 2:
                            this.HitsTwo++;
                            break;
                        case 3:
                            this.HitsThree++;
                            break;
                        case 4:
                            this.HitsFour++;
                            break;
                        case 5:
                            this.HitsFive++;
                            break;
                    }
                }
                if (this.Stars != null)
                {
                    var count = 0;
                    foreach (var s in this.Stars)
                    {
                        if (d.Stars.Contains(s))
                        {
                            count++;
                        }
                    }
                    switch (count)
                    {
                        case 0:
                            this.StarsZero++;
                            break;
                        case 1:
                            this.StarsOne++;
                            break;
                        case 2:
                            this.StarsTwo++;
                            break;
                    }
                }
            }
        }
        public void calculatePercentages(int count)
        {
            this.HitsZeroPercentage = this.calculatePercentage(this.HitsZero, count);
            this.HitsOnePercentage = this.calculatePercentage(this.HitsOne, count);
            this.HitsTwoPercentage = this.calculatePercentage(this.HitsTwo, count);
            this.HitsThreePercentage = this.calculatePercentage(this.HitsThree, count);
            this.HitsFourPercentage = this.calculatePercentage(this.HitsFour, count);
            this.HitsFivePercentage = this.calculatePercentage(this.HitsFive, count);
            this.StarsZeroPercentage = this.calculatePercentage(this.StarsZero, count);
            this.StarsOnePercentage = this.calculatePercentage(this.StarsOne, count);
            this.StarsTwoPercentage = this.calculatePercentage(this.StarsTwo, count);
        }
        private decimal calculatePercentage(int res, int count)
        {
            var percentage = ((double)res / (double)count) * (double)100;
            decimal perc = Decimal.Round((decimal)percentage, 4);
            return perc;
        }
    }
}