using System;
using System.Numerics;

namespace lab_4
{
    enum TransformerType { Autobot, Decepticon }

    internal partial class Transformer : IntelligentBeing, IDrivable
    {

        struct buildInfo
        {
            public int power;
            public int buildYear;
        } 
        buildInfo info;

        public string VehicleMode { get; set; }
        public bool IsTransformed { get; set; }

        public TransformerType Type { get; set; }
        public int Power { get => info.power; set => info.power = value; }
        public int BuildYear { get => info.buildYear; set => info.buildYear = value; }

        public Transformer(string name, int iq,int power, int buildYear , string vehicleMode, TransformerType type, bool isTransformed = false)
            : base(name, iq)
        {
            VehicleMode = vehicleMode;
            IsTransformed = isTransformed;
            Power = power;
            BuildYear = buildYear;
            Type = type;
        }


        public override string GetInfo()
        {
            string mode = IsTransformed ? VehicleMode : "Robot";
            return $"Transformer (abstract): {Name}, Mode: {mode}, IQ: {IQ}";
        }

        string IDrivable.GetInfo()
        {
            return $"Transformer (interface): {Name} can transform into {VehicleMode}";
        }

        public override string ToString()
        {
            string status = IsTransformed ? $"Transformed as {VehicleMode}" : "In robot mode";
            return $"Transformer: {Name}, IQ: {IQ}, {status}, Power: {this.info.power}, Year: {this.info.buildYear}, Type: {Type}";
        }

       
    }
}