namespace BuilderPattern
{
    class Computer
    {
        public string? HardDisk { get; set; }
        public string? Motherboard { get; set; }
        public string? Processor { get; set; }
        public string? Screen { get; set; }

        public string Configuration => $"Screen: {Screen}\nHard drive: {HardDisk}\nMotherboard: {Motherboard}\nProcessor: {Processor}";
    }
}