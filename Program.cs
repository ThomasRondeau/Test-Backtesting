namespace Test_Backtesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] eur_usd = {
            1.0835, 1.0850, 1.0820, 1.0865, 1.0810,
            1.0872, 1.0890, 1.0848, 1.0863, 1.0885,
            1.0912, 1.0920, 1.0897, 1.0931, 1.0903,
            1.0948, 1.0975, 1.0950, 1.0983, 1.0961,
            1.0992, 1.1015, 1.1040, 1.1025, 1.1051,
            1.1083, 1.1076, 1.1092, 1.1120, 1.1105
            };

            double[] usdJpyRates = {
            145.23, 145.45, 145.67, 145.89, 145.12,
            144.95, 145.30, 145.55, 145.75, 145.50,
            144.80, 144.95, 145.10, 145.35, 145.60,
            145.40, 145.20, 145.50, 145.75, 145.95,
            146.10, 146.25, 146.40, 146.55, 146.70,
            146.85, 146.95, 147.10, 147.25, 147.40
            };

            DateTime startDate = new DateTime(2024, 12, 1);
            DateTime[] dates = new DateTime[30];

            for (int i = 0; i < dates.Length; i++)
            {
                dates[i] = startDate.AddDays(i);
            }

            List<>

            Console.WriteLine("Hello, World!");
        }
    }
}