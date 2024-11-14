using System;
using System.Collections.Generic;

namespace TradeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // pega a data de referência
            Console.WriteLine("Enter the reference date (MM/DD/YYYY):");
            DateTime referenceDate = DateTime.Parse(Console.ReadLine());

            // pega o número de operações
            Console.WriteLine("Enter the number of trades:");
            int n = int.Parse(Console.ReadLine());

            List<ITrade> trades = new List<ITrade>();

            // perccorre cada operação
            Console.WriteLine("Enter each trade in the format 'Value ClientSector NextPaymentDate (MM/DD/YYYY)':");
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                double value = double.Parse(input[0]);
                string sector = input[1];
                DateTime nextPaymentDate =  DateTime.ParseExact(input[2], "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                bool isPoliticallyExposed = bool.Parse(input[3]);

                trades.Add(new Trade(value, sector, nextPaymentDate, isPoliticallyExposed));
            }

            // Classifica as operações
            TradeClassifier classifier = new TradeClassifier();
            Console.WriteLine("Trade Categories:");
            foreach (var trade in trades)
            {
                Console.WriteLine(classifier.ClassifyTrade(trade, referenceDate));
            }
        }
    }
}
