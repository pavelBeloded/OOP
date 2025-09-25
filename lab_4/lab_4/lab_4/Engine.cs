namespace lab_4
{
    internal class Engine
    {
        public string Type { get; set; }
        public int HorsePower { get; set; }
        public bool IsRunning { get; set; }

        public Engine(string type, int horsePower)
        {
            Type = type;
            HorsePower = horsePower;
            IsRunning = false;
        }

        public override string ToString()
        {
            return $"Engine: {Type}, Power: {HorsePower} HP, Running: {IsRunning}";
        }
    }
}