using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace FileProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("2012_nba_draft_combine.csv");
            using var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csvReader.GetRecords<Player>();
            DisplayByDraftOrder(records);
        }

        private static void DisplayByDraftOrder(IEnumerable<Player> records)
        {
            records = records.OrderBy(r => r.DraftPick);
            
            foreach (var player in records)
            {
                Console.WriteLine($"{player.DraftPick}, {player.PlayerName}");
            }
        }
    }
}
