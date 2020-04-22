using CsvHelper.Configuration.Attributes;

namespace FileProcessor
{
    public class Player
    {
        private int? Id { get; set; }
        [Name("Player")]
        public string PlayerName { get; set; }
        public int? Year { get; set; }
        [Name("Draft pick")]
        public int? DraftPick { get; set; }
        [Name("Height (No Shoes)")]
        public double? Height { get; set; }
        [Name("Height (With Shoes)")]
        public double? HeightWithShoes { get; set; }
        public double? Wingspan { get; set; }
        [Name("Standing reach")]
        public double? StandingReach { get; set; }
        [Name("Vertical (Max)")]
        public double? Vertical { get; set; }
        [Name("Vertical (Max Reach)")]
        public double? VerticalMaxReach { get; set; }
        [Name("Vertical (No Step)")]
        public double? VerticalNoStep { get; set; }
        [Name("Vertical (No Step Reach)")]
        public double? VerticalNoStepReach { get; set; }
        public double? Weight { get; set; }
        [Name("Body Fat")]
        public double? BodyFat { get; set; }
        [Name("Hand (Length)")]
        public double? HandLength { get; set; }
        [Name("Hand (Width)")]
        public double? HandWidth { get; set; }
        public double? Bench { get; set; }
        public double? Agility { get; set; }
        public double? Sprint { get; set; }
    }
}