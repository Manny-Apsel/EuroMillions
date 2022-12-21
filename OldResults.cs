namespace EM
{
    public class OldResults
    {
        public byte[] Numbers { get; set; }
        public int HitsZero { get; set; } = 0;
        public int HitsOne { get; set; } = 0;
        public int HitsTwo { get; set; } = 0;
        public int HitsThree { get; set; } = 0;
        public int HitsFour { get; set; } = 0;
        public int HitsFive { get; set; } = 0;

        public OldResults(byte[] toCheck)
        {
            this.Numbers = toCheck;
        }

        public void showResult(int count)
        {
            System.Console.WriteLine($"[{this.Numbers[0]}, {this.Numbers[1]}, {this.Numbers[2]}, {this.Numbers[3]}, {this.Numbers[4]}]");
            this.percentages(this.HitsZero, count, 0);
            this.percentages(this.HitsOne, count, 1);
            this.percentages(this.HitsTwo, count, 2);
            this.percentages(this.HitsThree, count, 3);
            this.percentages(this.HitsFour, count, 4);
            this.percentages(this.HitsFive, count, 5);
            System.Console.WriteLine();
        }

        private void percentages(int res, int count, byte i)
        {
            var percentage = ((double)res / (double)count) * (double)100;
            decimal perc = Decimal.Round((decimal)percentage, 4);
            System.Console.WriteLine($"hit {i} = {res} ({perc}%)");
        }
    }
}